namespace BuscaJob
{
    partial class frmCadastroCandi
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
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbUf = new System.Windows.Forms.MaskedTextBox();
            this.txbCep = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbNacionalidade = new System.Windows.Forms.ComboBox();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(381, 99);
            this.txbCidade.MaxLength = 58;
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(182, 20);
            this.txbCidade.TabIndex = 9;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(90, 98);
            this.txbBairro.MaxLength = 20;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(214, 20);
            this.txbBairro.TabIndex = 8;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(90, 72);
            this.txbEndereco.MaxLength = 40;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(415, 20);
            this.txbEndereco.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Bairro:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(90, 46);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(275, 20);
            this.txbEmail.TabIndex = 3;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(90, 14);
            this.txbNome.MaxLength = 50;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(415, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 158);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "Nascimento:";
            // 
            // txbNascimento
            // 
            this.txbNascimento.Location = new System.Drawing.Point(464, 46);
            this.txbNascimento.Mask = "00/00/0000";
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(80, 20);
            this.txbNascimento.TabIndex = 4;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(564, 14);
            this.txbCpf.Mask = "000.000.000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(91, 20);
            this.txbCpf.TabIndex = 2;
            // 
            // txbUf
            // 
            this.txbUf.Location = new System.Drawing.Point(604, 99);
            this.txbUf.Mask = "AA";
            this.txbUf.Name = "txbUf";
            this.txbUf.Size = new System.Drawing.Size(28, 20);
            this.txbUf.TabIndex = 10;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(90, 124);
            this.txbCep.Mask = "00.000-000";
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(66, 20);
            this.txbCep.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(550, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 15);
            this.label12.TabIndex = 46;
            this.label12.Text = "Nacionalidade:";
            // 
            // cbNacionalidade
            // 
            this.cbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidade.FormattingEnabled = true;
            this.cbNacionalidade.Items.AddRange(new object[] {
            "",
            "brasileiro(a)",
            "afegã(o)",
            "albanês(esa)",
            "alemã(ão)",
            "andorrano(a)",
            "angolano(a)",
            "anguilano(a)",
            "antiguano(a)",
            "antilhano(a)",
            "árabe-saudita",
            "argelino(a)",
            "argentino(a)",
            "arménio(a)",
            "arubano(a)",
            "australiano(a)",
            "austríaco(a)",
            "azeri",
            "baamiano(a)",
            "bangladechiano(a)",
            "barbadense",
            "barenita",
            "belga",
            "belizenho(a)",
            "benineseo(a)",
            "bermudense",
            "bielorrusso(a)",
            "birmanês(a)",
            "boliviano(a)",
            "bósnio(a)",
            "botsuano(a)",
            "britânico(a)",
            "bruneíno(a)",
            "búlgaro(a)",
            "burquino(a)",
            "burundiano(a)",
            "butanês(esa)",
            "cabo-verdiano(a)",
            "caimanês(a)",
            "camaronês(esa)",
            "cambojano(a)",
            "canadiano(a)",
            "catariano(a)",
            "cazaque",
            "centro-africano(a)",
            "chadiano(a)",
            "chileno(a)",
            "chinês(esa)",
            "cingalês(a)",
            "cipriota",
            "colombiano(a)",
            "comoriano(a)",
            "congolês(a)",
            "congolês(a)",
            "cookense",
            "costarriquenho(a)",
            "croata",
            "cubano(a)",
            "curaçauense",
            "dinamarquês(esa)",
            "dominicano(a)",
            "dominiquês(esa)",
            "egípcio(a)",
            "emiradense",
            "equatoriano(a)",
            "eritreu(ia)",
            "escocês(esa)",
            "eslovaco(a)",
            "esloveno(a)",
            "espanhol(a)",
            "essuatiniano(a)",
            "estónio(a)",
            "etíope",
            "faroense",
            "fijiano(a)",
            "filipino",
            "finlandês(esa)",
            "francês(esa)",
            "gabonês(a)",
            "galês(esa)",
            "gambiano(a)",
            "ganês(a)",
            "georgiano(a)",
            "granadino(a)",
            "grego(a)",
            "guadalupense",
            "guamês(a)",
            "guatemalteco(a)",
            "guianense",
            "guianês(esa)",
            "guineano(a)",
            "guineense",
            "guinéu-equatoriano(a)",
            "haitiano(a)",
            "honconguês(esa)",
            "hondurenho(a)",
            "húngaro(a)",
            "iemenita",
            "indiano(a)",
            "indonésia(o)",
            "inglês(esa)",
            "iraniano(a)",
            "iraquiano(a)",
            "irlandês(a)",
            "islandês(esa)",
            "israelense",
            "italiano(a)",
            "jamaicano(a)",
            "japonês(esa)",
            "jibutiano(a)",
            "jordano(a)",
            "kosovar",
            "kuwaitiano(a)",
            "laociano(a)",
            "lesotiano(a)",
            "letã(o)",
            "libanês(a)",
            "liberiano(a)",
            "líbio(a)",
            "listenstainiano(a)",
            "lituano(a)",
            "luxemburguês(a)",
            "macaense",
            "macedónico(a)",
            "malaio(a)",
            "malauiano(a)",
            "maldivo(a)",
            "malgaxe",
            "maliano",
            "maltês(a)",
            "marfinense",
            "marroquino(a)",
            "martinicano(a)",
            "mauriciano(a)",
            "mauritano(a)",
            "mexicano(a)",
            "micronésio(a)",
            "moçambicano(a)",
            "moldavo(a)",
            "monegasco(a)",
            "mongol",
            "monserratense",
            "montenegrino(a)",
            "namibiano(a)",
            "nauruano(a)",
            "neerlandês(a)",
            "neocaledónio(a)",
            "neozelandês(esa)",
            "nepalês(a)",
            "nicaraguense",
            "nigeriano(a)",
            "nigerino(a)",
            "norte-americano(a)",
            "norte-coreano(a)",
            "norte-irlandês(esa)",
            "norueguês(esa)",
            "omanense",
            "palauano(a)",
            "palestiniano(a)",
            "panamenho(a)",
            "papua",
            "paquistanês(a)",
            "paraguaio(a)",
            "peruano(a)",
            "polaco(a)",
            "polinésio(a)",
            "porto-riquenho(a)",
            "português(a)",
            "queniano(a)",
            "quirguiz",
            "quiribatiano(a)",
            "romeno(a)",
            "ruandês(a)",
            "russo(a)",
            "salomonense",
            "salvadorenho(a)",
            "samoano(a)",
            "samoense",
            "santa-luciense",
            "são-cristovense",
            "são-marinhense",
            "são-martinhense",
            "são-martinhense",
            "são-tomense",
            "são-vicentino(a)",
            "seichelense",
            "senegalês(esa)",
            "serra-leonês(a)",
            "sérvio(a)",
            "singapurense",
            "sírio(a)",
            "somali",
            "sudanês(a)",
            "sueco(a)",
            "suíço(a)",
            "sul-africano(a)",
            "sul-coreano(a)",
            "surinamês(a)",
            "tailandês",
            "taiwanês(a)",
            "taiwanês(a)",
            "tajique",
            "tanzaniano(a)",
            "tcheco(a)",
            "timorense",
            "togolês(a)",
            "tonganês(esa)",
            "trinitário(a)-tobagense",
            "tunisino(a)",
            "turco(a)",
            "turquemeno(a)",
            "turquense",
            "tuvaluano(a)",
            "ucraniano(a)",
            "ugandense",
            "uruguaio(a)",
            "usbeque",
            "vanuatuense",
            "vaticano(a)",
            "venezuelano(a)",
            "vietnamita",
            "virginense",
            "virginense",
            "zambiano(a)",
            "zimbabuano(a)"});
            this.cbNacionalidade.Location = new System.Drawing.Point(660, 45);
            this.cbNacionalidade.Name = "cbNacionalidade";
            this.cbNacionalidade.Size = new System.Drawing.Size(121, 21);
            this.cbNacionalidade.TabIndex = 5;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(569, 71);
            this.txbComplemento.MaxLength = 20;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(173, 20);
            this.txbComplemento.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(511, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "Compl.";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 159);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 50;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(699, 159);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 51;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(618, 159);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 52;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(673, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(157, 15);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "ID (apenas para testes)";
            // 
            // frmCadastroCandi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 194);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbNacionalidade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.txbUf);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroCandi";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastroCandi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txbNascimento;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.MaskedTextBox txbUf;
        private System.Windows.Forms.MaskedTextBox txbCep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbNacionalidade;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblId;
    }
}