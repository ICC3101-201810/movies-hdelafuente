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
            this.button1 = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
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
            // 
            // SearchActors
            // 
            this.SearchActors.Location = new System.Drawing.Point(120, 77);
            this.SearchActors.Name = "SearchActors";
            this.SearchActors.Size = new System.Drawing.Size(75, 23);
            this.SearchActors.TabIndex = 2;
            this.SearchActors.Text = "Actores";
            this.SearchActors.UseVisualStyleBackColor = true;
            // 
            // SearchDirector
            // 
            this.SearchDirector.Location = new System.Drawing.Point(201, 77);
            this.SearchDirector.Name = "SearchDirector";
            this.SearchDirector.Size = new System.Drawing.Size(75, 23);
            this.SearchDirector.TabIndex = 3;
            this.SearchDirector.Text = "Directores";
            this.SearchDirector.UseVisualStyleBackColor = true;
            // 
            // SearchStudio
            // 
            this.SearchStudio.Location = new System.Drawing.Point(282, 77);
            this.SearchStudio.Name = "SearchStudio";
            this.SearchStudio.Size = new System.Drawing.Size(75, 23);
            this.SearchStudio.TabIndex = 4;
            this.SearchStudio.Text = "Estudios";
            this.SearchStudio.UseVisualStyleBackColor = true;
            // 
            // SearchProducer
            // 
            this.SearchProducer.Location = new System.Drawing.Point(363, 77);
            this.SearchProducer.Name = "SearchProducer";
            this.SearchProducer.Size = new System.Drawing.Size(75, 23);
            this.SearchProducer.TabIndex = 5;
            this.SearchProducer.Text = "Productor";
            this.SearchProducer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.Location = new System.Drawing.Point(39, 135);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(399, 273);
            this.ListView.TabIndex = 7;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 420);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchProducer);
            this.Controls.Add(this.SearchStudio);
            this.Controls.Add(this.SearchDirector);
            this.Controls.Add(this.SearchActors);
            this.Controls.Add(this.SearchMovies);
            this.Controls.Add(this.SearchBar);
            this.Name = "Searcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ListView;
    }
}