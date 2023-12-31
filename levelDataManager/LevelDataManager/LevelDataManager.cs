﻿using levelDataManager;
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
    public partial class LevelDataManager : Form
    {
        List<LevelData> data;
        public LevelDataManager()
        {
            InitializeComponent();
            data = new List<LevelData>();
        }

        private void LoadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Selecione o arquivo leveldata.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonFilePath = openFileDialog.FileName;
                string json = File.ReadAllText(jsonFilePath);
                LevelDataContainer container = JsonConvert.DeserializeObject<LevelDataContainer>(json);
                data = container.Data;
                RefreshData();
            }
        }

        private void RefreshData()
        {
            data = data.OrderBy(d => d.position_lvl).ToList();
            //dtLevelData.DataSource = null;
            dtLevelData.DataSource = data;
            dtLevelData.Columns["position_lvl"].ReadOnly = true;

            dtLevelData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dtLevelData.Columns["position_lvl"].HeaderText = "Posição";
            dtLevelData.Columns["name_lvl"].HeaderText = "Nome";
            dtLevelData.Columns["creator_lvl"].HeaderText = "Criador";
            dtLevelData.Columns["verifier_lvl"].HeaderText = "Verificador";
            dtLevelData.Columns["video_lvl"].HeaderText = "Link Vídeo";
            dtLevelData.Columns["publisher_lvl"].HeaderText = "Publicador";
            dtLevelData.Columns["listpct_lvl"].HeaderText = "List%";
        }

        private void AddLevel(LevelData newLevel)
        {
            // Atualize as posições dos levels existentes
            foreach (var level in data)
            {
                if (level.position_lvl >= newLevel.position_lvl)
                {
                    level.position_lvl++;
                }
            }

            // Adicione o novo level
            data.Add(newLevel);
        }

        private void DeleteLevel(int position)
        {
            // Encontre o level para deletar
            LevelData levelToDelete = data.FirstOrDefault(d => d.position_lvl == position);

            // Se o level não foi encontrado, retorne
            if (levelToDelete == null)
            {
                MessageBox.Show("Level não encontrado.");
                return;
            }

            // Remova o level
            data.Remove(levelToDelete);

            // Atualize as posições dos levels acima
            foreach (var level in data)
            {
                if (level.position_lvl > position)
                {
                    level.position_lvl--;
                }
            }
        }

        private void SaveDataToFile()
        {
            try
            {
                List<LevelData> data = (List<LevelData>)dtLevelData.DataSource;
                var dataWithTimestamp = new
                {
                    GeradoEm = DateTime.Now.ToString(),
                    Data = data
                };
                string json = JsonConvert.SerializeObject(dataWithTimestamp, Formatting.Indented);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Salvar arquivo JSON";
                saveFileDialog.FileName = "NEWleveldata"; // Pré-sugestão do nome do arquivo

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

        private void btNewLevel_Click(object sender, EventArgs e)
        {
            LevelData newLevel = new LevelData();

            string position_lvl = Interaction.InputBox("Digite a posição do level", "Adicionar Level");

            if (string.IsNullOrEmpty(position_lvl))
            {
                return;
            }

            try
            {
                newLevel.position_lvl = int.Parse(position_lvl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            newLevel.name_lvl = Interaction.InputBox("Digite o nome do level", "Adicionar Level");
            newLevel.creator_lvl = Interaction.InputBox("Digite o criador do level", "Adicionar Level");
            newLevel.verifier_lvl = Interaction.InputBox("Digite o verificador do level", "Adicionar Level");
            newLevel.video_lvl = Interaction.InputBox("Digite o link do vídeo do level", "Adicionar Level");
            newLevel.publisher_lvl = Interaction.InputBox("Digite o publicador do level (deixe em branco caso seja o próprio criador)", "Adicionar Level");
            if(int.Parse(position_lvl) <= 30)
            {
                do
                {
                    string listpct = Interaction.InputBox("Digite o List% do level (apenas número)", "Adicionar Level");
                    if (string.IsNullOrEmpty(listpct))
                    {
                        return;
                    }
                    try
                    {
                        newLevel.listpct_lvl = int.Parse(listpct);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }while (newLevel.listpct_lvl < 0 || newLevel.listpct_lvl > 100);
            }

            string message =
                     $"Você está prestes a adicionar o seguinte level:\n\n" +
                     $"Posição: {newLevel.position_lvl}\n" +
                     $"Nome: {newLevel.name_lvl}\n" +
                     $"Criador: {newLevel.creator_lvl}\n" +
                     $"Verificador: {newLevel.verifier_lvl}\n" +
                     $"Vídeo: {newLevel.video_lvl}\n" +
                     $"Publicador: {newLevel.publisher_lvl}\n";
            if (newLevel.listpct_lvl != null)
            {
                message += $"List%: {newLevel.listpct_lvl}\n\n";
            }
                     message += "Adicionar?";
            DialogResult result = MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                AddLevel(newLevel);
                RefreshData();
            }
        }

        private void btDeleteLevel_Click(object sender, EventArgs e)
        {
            // Solicite a posição do level para deletar
            string position_lvl = Interaction.InputBox("Digite a posição do level que deseja DELETAR", "Deletar Level");

            if (string.IsNullOrEmpty(position_lvl))
            {
                return;
            }

            try
            {
                int position = int.Parse(position_lvl);

                // Encontre o level para deletar
                LevelData levelToDelete = data.FirstOrDefault(d => d.position_lvl == position);

                // Se o level não foi encontrado, retorne
                if (levelToDelete == null)
                {
                    MessageBox.Show("Level não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string message = 
                         $"Você está prestes a DELETAR o seguinte level:\n\n" +
                         $"Posição: {levelToDelete.position_lvl}\n" +
                         $"Nome: {levelToDelete.name_lvl}\n" +
                         $"Criador: {levelToDelete.creator_lvl}\n" +
                         $"Verificador: {levelToDelete.verifier_lvl}\n" +
                         $"Vídeo: {levelToDelete.video_lvl}\n" +
                         $"Publicador: {levelToDelete.publisher_lvl}\n\n" +
                         $"DELETAR?";
                DialogResult result = MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo);

                // Se o usuário confirmou, delete o level
                if (result == DialogResult.Yes)
                {
                    DeleteLevel(Convert.ToInt32(position_lvl));
                    RefreshData();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido para a posição do level.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveFile_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void btLoadFile_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btSubirPos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenha o índice da linha selecionada
                int rowIndex = dtLevelData.SelectedCells[0].OwningRow.Index;

                // Verifique se a linha não é a primeira
                if (rowIndex == 0)
                    return;

                // Obtenha o level selecionado e o level acima dele
                LevelData selectedLevel = data[rowIndex];
                LevelData aboveLevel = data[rowIndex - 1];

                // Troque as posições dos levels
                int temp = selectedLevel.position_lvl.Value;
                selectedLevel.position_lvl = aboveLevel.position_lvl;
                aboveLevel.position_lvl = temp;

                // Atualize os dados e a visualização
                RefreshData();

                // Mantenha a linha selecionada
                dtLevelData.Rows[rowIndex - 1].Selected = true;
            }
            catch
            {

            }
        }

        private void btDescerPos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenha o índice da linha selecionada
                int rowIndex = dtLevelData.SelectedCells[0].OwningRow.Index;

                // Verifique se a linha não é a última
                if (rowIndex == dtLevelData.Rows.Count - 1)
                    return;

                // Obtenha o level selecionado e o level abaixo dele
                LevelData selectedLevel = data[rowIndex];
                LevelData belowLevel = data[rowIndex + 1];

                // Troque as posições dos levels
                int temp = selectedLevel.position_lvl.Value;
                selectedLevel.position_lvl = belowLevel.position_lvl;
                belowLevel.position_lvl = temp;

                // Atualize os dados e a visualização
                RefreshData();

                // Mantenha a linha selecionada
                dtLevelData.Rows[rowIndex + 1].Selected = true;
            }
            catch
            {

            }
        }

        private void btPlayerDataManager_Click(object sender, EventArgs e)
        {
            PlayerDataManager frm = new PlayerDataManager();
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
            this.Hide();
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}