﻿namespace _3935_APP2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1º Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "2º Número";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(136, 44);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(73, 20);
            this.txt_1.TabIndex = 2;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1_KeyPress);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(136, 108);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(73, 20);
            this.txt_2.TabIndex = 3;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_2_KeyPress);
            // 
            // btn_mais
            // 
            this.btn_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mais.Location = new System.Drawing.Point(248, 42);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(51, 32);
            this.btn_mais.TabIndex = 4;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menos.Location = new System.Drawing.Point(248, 96);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(51, 32);
            this.btn_menos.TabIndex = 5;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // btn_vezes
            // 
            this.btn_vezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vezes.Location = new System.Drawing.Point(316, 42);
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.Size = new System.Drawing.Size(51, 32);
            this.btn_vezes.TabIndex = 6;
            this.btn_vezes.Text = "X";
            this.btn_vezes.UseVisualStyleBackColor = true;
            this.btn_vezes.Click += new System.EventHandler(this.btn_vezes_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(316, 95);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(51, 32);
            this.btn_dividir.TabIndex = 7;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(248, 149);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(119, 32);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resultado.Location = new System.Drawing.Point(136, 155);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(73, 23);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 233);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

