using levelDataManager;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace levelDataManager
{
    public partial class PlayerDataManager : Form
    {
        List<PlayerData> data;
        public PlayerDataManager()
        {
            InitializeComponent();
            data = new List<PlayerData>();
        }

        private void LoadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Selecione o arquivo playerdata.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonFilePath = openFileDialog.FileName;
                string json = File.ReadAllText(jsonFilePath);
                PlayerDataContainer container = JsonConvert.DeserializeObject<PlayerDataContainer>(json);
                data = container.Data;
                RefreshData();
            }
        }

        private void RefreshData()
        {
            DataTable dt = new DataTable();
            dt = ConvertToDataTable(data); // Converta sua lista para DataTable

            DataView dv = dt.DefaultView;
            dv.Sort = "level_name asc"; // Classifique o DataView
            dtPlayerData.DataSource = dv.ToTable(); // Defina o DataView classificado como a fonte de dados

            dtPlayerData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dtPlayerData.Columns["level_name"].HeaderText = "Nome do Nível";
            dtPlayerData.Columns["player_name"].HeaderText = "Nome do Jogador";
            dtPlayerData.Columns["progress"].HeaderText = "Progresso";
            dtPlayerData.Columns["video"].HeaderText = "Link do Vídeo";
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void AddRecord()
        {
            PlayerData newRecord = new PlayerData();

            newRecord.level_name = Interaction.InputBox("Digite o nome do level", "Adicionar Player");
            if(string.IsNullOrEmpty(newRecord.level_name))
            {
                return;
            }
            newRecord.player_name = Interaction.InputBox("Digite o nome do jogador", "Adicionar Player");
            string progress = Interaction.InputBox("Digite o progresso do jogador (apenas número)", "Adicionar Player");

            try
            {
                if((int.Parse(progress) < 0) || (int.Parse(progress) > 100))
                {
                    MessageBox.Show("Porcentagem inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newRecord.progress = int.Parse(progress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            newRecord.video = Interaction.InputBox("Digite o link do vídeo do jogador (vazio para um progresso sem vídeo - cuidado)", "Adicionar Player");

            string message =
                     $"Você está prestes a adicionar o seguinte record:\n\n" +
                     $"Nome do Level: {newRecord.level_name}\n" +
                     $"Nome do Jogador: {newRecord.player_name}\n" +
                     $"Progresso: {newRecord.progress}\n" +
                     $"Vídeo: {newRecord.video}\n\n" +
                     $"Adicionar?";
            DialogResult result = MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                data.Add(newRecord);
                RefreshData();
            }
        }

        private void DeleteRecord()
        {
            // Verifique se um registro foi selecionado
            if (dtPlayerData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um registro para deletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtenha o nome do level e o nome do jogador do registro selecionado
            string level_name = dtPlayerData.SelectedRows[0].Cells["level_name"].Value.ToString();
            string player_name = dtPlayerData.SelectedRows[0].Cells["player_name"].Value.ToString();

            // Encontre o registro para deletar
            var recordToDelete = data.FirstOrDefault(d => d.level_name == level_name && d.player_name == player_name);

            // Se o registro não foi encontrado, retorne
            if (recordToDelete == null)
            {
                MessageBox.Show("Registro não encontrado.");
                return;
            }

            string message =
                     $"Você está prestes a DELETAR o seguinte registro:\n\n" +
                     $"Nome do Level: {recordToDelete.level_name}\n" +
                     $"Nome do Jogador: {recordToDelete.player_name}\n" +
                     $"Progresso: {recordToDelete.progress}\n" +
                     $"Vídeo: {recordToDelete.video}\n\n" +
                     $"DELETAR?";
            DialogResult result = MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo);

            // Se o usuário confirmou, delete o registro
            if (result == DialogResult.Yes)
            {
                // Remova o registro
                data.Remove(recordToDelete);

                RefreshData();
            }

        }

        private void btNewRecord_Click(object sender, EventArgs e)
        {
            AddRecord();
        }


        private void SaveDataToFile()
        {
            try
            {
                // Converta o DataView de volta para List<PlayerData>
                DataTable dt = (DataTable)dtPlayerData.DataSource;
                List<PlayerData> data = dt.AsEnumerable().Select(row =>
                    new PlayerData
                    {
                        player_name = row.Field<string>("player_name"),
                        level_name = row.Field<string>("level_name"),
                        progress = row.Field<int>("progress"),
                        video = row.Field<string>("video")
                    }).ToList();

                var dataWithTimestamp = new
                {
                    GeradoEm = DateTime.Now.ToString(),
                    Data = data
                };
                string json = JsonConvert.SerializeObject(dataWithTimestamp, Formatting.Indented);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Salvar arquivo JSON";
                saveFileDialog.FileName = "NEWplayerdata"; // Pré-sugestão do nome do arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonFilePath = saveFileDialog.FileName;
                    File.WriteAllText(jsonFilePath, json);
                    MessageBox.Show("Arquivo salvo com sucesso.", "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void btLevelDataManager_Click(object sender, EventArgs e)
        {
            LevelDataManager frm = new LevelDataManager();
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
            this.Hide();
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btLoadFile_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btSaveFile_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void btDeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }
    }
}
