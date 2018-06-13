namespace Movies
{
    partial class Searcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchMovies = new System.Windows.Forms.Button();
            this.SearchActors = new System.Windows.Forms.Button();
            this.SearchDirector = new System.Windows.Forms.Button();
            this.SearchStudio = new System.Windows.Forms.Button();
            this.SearchProducer = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.Perfil = new System.Windows.Forms.Panel();
            this.Boton_Criticas = new System.Windows.Forms.Button();
            this.Texto_Perfil = new System.Windows.Forms.Label();
            this.PanelCriticas = new System.Windows.Forms.Panel();
            this.BoxNombre = new System.Windows.Forms.TextBox();
            this.BoxMensaje = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Perfil.SuspendLayout();
            this.PanelCriticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(39, 37);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(399, 20);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.Text = "Search...";
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SearchMovies
            // 
            this.SearchMovies.Location = new System.Drawing.Point(39, 77);
            this.SearchMovies.Name = "SearchMovies";
            this.SearchMovies.Size = new System.Drawing.Size(75, 23);
            this.SearchMovies.TabIndex = 1;
            this.SearchMovies.Text = "Peliculas";
            this.SearchMovies.UseVisualStyleBackColor = true;
            this.SearchMovies.Click += new System.EventHandler(this.SearchMovies_Click);
            // 
            // SearchActors
            // 
            this.SearchActors.Location = new System.Drawing.Point(120, 77);
            this.SearchActors.Name = "SearchActors";
            this.SearchActors.Size = new System.Drawing.Size(75, 23);
            this.SearchActors.TabIndex = 2;
            this.SearchActors.Text = "Actores";
            this.SearchActors.UseVisualStyleBackColor = true;
            this.SearchActors.Click += new System.EventHandler(this.SearchActors_Click);
            // 
            // SearchDirector
            // 
            this.SearchDirector.Location = new System.Drawing.Point(201, 77);
            this.SearchDirector.Name = "SearchDirector";
            this.SearchDirector.Size = new System.Drawing.Size(75, 23);
            this.SearchDirector.TabIndex = 3;
            this.SearchDirector.Text = "Directores";
            this.SearchDirector.UseVisualStyleBackColor = true;
            this.SearchDirector.Click += new System.EventHandler(this.SearchDirector_Click);
            // 
            // SearchStudio
            // 
            this.SearchStudio.Location = new System.Drawing.Point(282, 77);
            this.SearchStudio.Name = "SearchStudio";
            this.SearchStudio.Size = new System.Drawing.Size(75, 23);
            this.SearchStudio.TabIndex = 4;
            this.SearchStudio.Text = "Estudios";
            this.SearchStudio.UseVisualStyleBackColor = true;
            this.SearchStudio.Click += new System.EventHandler(this.SearchStudio_Click);
            // 
            // SearchProducer
            // 
            this.SearchProducer.Location = new System.Drawing.Point(363, 77);
            this.SearchProducer.Name = "SearchProducer";
            this.SearchProducer.Size = new System.Drawing.Size(75, 23);
            this.SearchProducer.TabIndex = 5;
            this.SearchProducer.Text = "Productor";
            this.SearchProducer.UseVisualStyleBackColor = true;
            this.SearchProducer.Click += new System.EventHandler(this.SearchProducer_Click);
            // 
            // ListView
            // 
            this.ListView.Location = new System.Drawing.Point(39, 106);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(399, 302);
            this.ListView.TabIndex = 7;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // Perfil
            // 
            this.Perfil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Perfil.Controls.Add(this.Boton_Criticas);
            this.Perfil.Controls.Add(this.Texto_Perfil);
            this.Perfil.Location = new System.Drawing.Point(458, 37);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(235, 371);
            this.Perfil.TabIndex = 8;
            // 
            // Boton_Criticas
            // 
            this.Boton_Criticas.Location = new System.Drawing.Point(89, 329);
            this.Boton_Criticas.Name = "Boton_Criticas";
            this.Boton_Criticas.Size = new System.Drawing.Size(75, 23);
            this.Boton_Criticas.TabIndex = 1;
            this.Boton_Criticas.Text = "Dejar Critica";
            this.Boton_Criticas.UseVisualStyleBackColor = true;
            this.Boton_Criticas.Click += new System.EventHandler(this.Boton_Criticas_Click);
            // 
            // Texto_Perfil
            // 
            this.Texto_Perfil.AutoSize = true;
            this.Texto_Perfil.Location = new System.Drawing.Point(18, 20);
            this.Texto_Perfil.Name = "Texto_Perfil";
            this.Texto_Perfil.Size = new System.Drawing.Size(110, 26);
            this.Texto_Perfil.TabIndex = 0;
            this.Texto_Perfil.Text = "Seleccione un objeto \npara mostrar su perfil";
            // 
            // PanelCriticas
            // 
            this.PanelCriticas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelCriticas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelCriticas.Controls.Add(this.Send);
            this.PanelCriticas.Controls.Add(this.BoxMensaje);
            this.PanelCriticas.Controls.Add(this.BoxNombre);
            this.PanelCriticas.Location = new System.Drawing.Point(699, 37);
            this.PanelCriticas.Name = "PanelCriticas";
            this.PanelCriticas.Size = new System.Drawing.Size(200, 371);
            this.PanelCriticas.TabIndex = 9;
            // 
            // BoxNombre
            // 
            this.BoxNombre.Location = new System.Drawing.Point(20, 22);
            this.BoxNombre.Name = "BoxNombre";
            this.BoxNombre.Size = new System.Drawing.Size(100, 20);
            this.BoxNombre.TabIndex = 0;
            this.BoxNombre.Text = "Nombre";
            // 
            // BoxMensaje
            // 
            this.BoxMensaje.Location = new System.Drawing.Point(20, 48);
            this.BoxMensaje.Multiline = true;
            this.BoxMensaje.Name = "BoxMensaje";
            this.BoxMensaje.Size = new System.Drawing.Size(161, 271);
            this.BoxMensaje.TabIndex = 1;
            this.BoxMensaje.Text = "Critica...";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(106, 329);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Enviar";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click_1);
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 420);
            this.Controls.Add(this.PanelCriticas);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.SearchProducer);
            this.Controls.Add(this.SearchStudio);
            this.Controls.Add(this.SearchDirector);
            this.Controls.Add(this.SearchActors);
            this.Controls.Add(this.SearchMovies);
            this.Controls.Add(this.SearchBar);
            this.Name = "Searcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
            this.Perfil.ResumeLayout(false);
            this.Perfil.PerformLayout();
            this.PanelCriticas.ResumeLayout(false);
            this.PanelCriticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchMovies;
        private System.Windows.Forms.Button SearchActors;
        private System.Windows.Forms.Button SearchDirector;
        private System.Windows.Forms.Button SearchStudio;
        private System.Windows.Forms.Button SearchProducer;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Panel Perfil;
        private System.Windows.Forms.Label Texto_Perfil;
        private System.Windows.Forms.Button Boton_Criticas;
        private System.Windows.Forms.Panel PanelCriticas;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox BoxMensaje;
        private System.Windows.Forms.TextBox BoxNombre;
    }
}