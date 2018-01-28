namespace GesServicios.controles.forms
{
    partial class Suministros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suministros));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.lbSumNumero = new Controles.labels.lblEtiqueta();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.dtpFechaAlta = new Controles.Fecha.dtpFecha();
            this.lblTipoMedidor = new Controles.labels.lblEtiqueta();
            this.lblFechaAlta = new Controles.labels.lblEtiqueta();
            this.cmbTipoConexion = new Controles.datos.cmbLista();
            this.cmbZona = new Controles.datos.cmbLista();
            this.txtConsumoEstimado = new Controles.textBoxes.gesTextBox();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblPotenciaL1 = new Controles.labels.lblEtiqueta();
            this.cmbCategoria = new Controles.datos.cmbLista();
            this.cmbRuta = new Controles.datos.cmbLista();
            this.lblTipoConexion = new Controles.labels.lblEtiqueta();
            this.lblCategoria = new Controles.labels.lblEtiqueta();
            this.lblPotenciaL2 = new Controles.labels.lblEtiqueta();
            this.lblConsumoEstimado = new Controles.labels.lblEtiqueta();
            this.lblPotenciaL3 = new Controles.labels.lblEtiqueta();
            this.lblOrdenRuta = new Controles.labels.lblEtiqueta();
            this.lblRuta = new Controles.labels.lblEtiqueta();
            this.txtPotenciaL1 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtSumNumero = new Controles.textBoxes.txtDescripcionCorta();
            this.cmbServicio = new Controles.datos.cmbLista();
            this.lblServicio = new Controles.labels.lblEtiqueta();
            this.txtOrdenRuta = new Controles.textBoxes.txtDescripcionCorta();
            this.lblNumeroProv = new Controles.labels.lblEtiqueta();
            this.txtPotenciaL2 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtPotenciaL3 = new Controles.textBoxes.txtDescripcionCorta();
            this.chkPermiteCorte = new Controles.datos.chkBox();
            this.chkPermiteFacturacion = new Controles.datos.chkBox();
            this.chkBoxMedido = new Controles.datos.chkBox();
            this.btnVer = new Controles.buttons.btnVer();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(159, 360);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(451, 89);
            this.gesGroup2.TabIndex = 4;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(329, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lbSumNumero
            // 
            this.lbSumNumero.AutoSize = true;
            this.lbSumNumero.Location = new System.Drawing.Point(13, 25);
            this.lbSumNumero.Name = "lbSumNumero";
            this.lbSumNumero.Size = new System.Drawing.Size(73, 13);
            this.lbSumNumero.TabIndex = 0;
            this.lbSumNumero.Text = "N° Suministro:";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnVer);
            this.gbDatos.Controls.Add(this.lblNumeroProv);
            this.gbDatos.Controls.Add(this.cmbZona);
            this.gbDatos.Controls.Add(this.lblTipoMedidor);
            this.gbDatos.Controls.Add(this.cmbServicio);
            this.gbDatos.Controls.Add(this.lblServicio);
            this.gbDatos.Controls.Add(this.dtpFechaAlta);
            this.gbDatos.Controls.Add(this.lblFechaAlta);
            this.gbDatos.Controls.Add(this.cmbTipoConexion);
            this.gbDatos.Controls.Add(this.txtConsumoEstimado);
            this.gbDatos.Controls.Add(this.chkPermiteFacturacion);
            this.gbDatos.Controls.Add(this.chkPermiteCorte);
            this.gbDatos.Controls.Add(this.chkBoxMedido);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblPotenciaL1);
            this.gbDatos.Controls.Add(this.cmbCategoria);
            this.gbDatos.Controls.Add(this.cmbRuta);
            this.gbDatos.Controls.Add(this.lblTipoConexion);
            this.gbDatos.Controls.Add(this.lblCategoria);
            this.gbDatos.Controls.Add(this.lblPotenciaL2);
            this.gbDatos.Controls.Add(this.lblConsumoEstimado);
            this.gbDatos.Controls.Add(this.lblPotenciaL3);
            this.gbDatos.Controls.Add(this.lblOrdenRuta);
            this.gbDatos.Controls.Add(this.lblRuta);
            this.gbDatos.Controls.Add(this.txtOrdenRuta);
            this.gbDatos.Controls.Add(this.txtPotenciaL3);
            this.gbDatos.Controls.Add(this.txtPotenciaL2);
            this.gbDatos.Controls.Add(this.txtPotenciaL1);
            this.gbDatos.Controls.Add(this.txtSumNumero);
            this.gbDatos.Controls.Add(this.lbSumNumero);
            this.gbDatos.Location = new System.Drawing.Point(2, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(615, 351);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(110, 122);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.dtpFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAlta.TabIndex = 13;
            // 
            // lblTipoMedidor
            // 
            this.lblTipoMedidor.AutoSize = true;
            this.lblTipoMedidor.Location = new System.Drawing.Point(13, 222);
            this.lblTipoMedidor.Name = "lblTipoMedidor";
            this.lblTipoMedidor.Size = new System.Drawing.Size(35, 13);
            this.lblTipoMedidor.TabIndex = 24;
            this.lblTipoMedidor.Text = "Zona:";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(13, 122);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(76, 13);
            this.lblFechaAlta.TabIndex = 24;
            this.lblFechaAlta.Text = "Fecha de Alta:";
            // 
            // cmbTipoConexion
            // 
            this.cmbTipoConexion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoConexion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoConexion.FormattingEnabled = true;
            this.cmbTipoConexion.Location = new System.Drawing.Point(110, 52);
            this.cmbTipoConexion.Name = "cmbTipoConexion";
            this.cmbTipoConexion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbTipoConexion.Size = new System.Drawing.Size(165, 21);
            this.cmbTipoConexion.TabIndex = 10;
            // 
            // cmbZona
            // 
            this.cmbZona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbZona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(54, 219);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbZona.Size = new System.Drawing.Size(165, 21);
            this.cmbZona.TabIndex = 12;
            // 
            // txtConsumoEstimado
            // 
            this.txtConsumoEstimado.BackColor = System.Drawing.Color.Red;
            this.txtConsumoEstimado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsumoEstimado.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtConsumoEstimado.Location = new System.Drawing.Point(119, 148);
            this.txtConsumoEstimado.MaxLength = 15;
            this.txtConsumoEstimado.Name = "txtConsumoEstimado";
            this.txtConsumoEstimado.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtConsumoEstimado.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoEstimado.TabIndex = 6;
            this.txtConsumoEstimado.TextoVacio = "<Descripcion>";
            this.txtConsumoEstimado.TipoControl = Controles.util.Enumerados.enumTipos.Decimal;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(32, 285);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 14;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblPotenciaL1
            // 
            this.lblPotenciaL1.AutoSize = true;
            this.lblPotenciaL1.Location = new System.Drawing.Point(12, 185);
            this.lblPotenciaL1.Name = "lblPotenciaL1";
            this.lblPotenciaL1.Size = new System.Drawing.Size(67, 13);
            this.lblPotenciaL1.TabIndex = 22;
            this.lblPotenciaL1.Text = "Potencia L1:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(396, 52);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbCategoria.Size = new System.Drawing.Size(165, 21);
            this.cmbCategoria.TabIndex = 9;
            // 
            // cmbRuta
            // 
            this.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(391, 219);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbRuta.Size = new System.Drawing.Size(165, 21);
            this.cmbRuta.TabIndex = 11;
            // 
            // lblTipoConexion
            // 
            this.lblTipoConexion.AutoSize = true;
            this.lblTipoConexion.Location = new System.Drawing.Point(13, 52);
            this.lblTipoConexion.Name = "lblTipoConexion";
            this.lblTipoConexion.Size = new System.Drawing.Size(93, 13);
            this.lblTipoConexion.TabIndex = 22;
            this.lblTipoConexion.Text = "Tipo de Conexión:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(299, 55);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPotenciaL2
            // 
            this.lblPotenciaL2.AutoSize = true;
            this.lblPotenciaL2.Location = new System.Drawing.Point(218, 185);
            this.lblPotenciaL2.Name = "lblPotenciaL2";
            this.lblPotenciaL2.Size = new System.Drawing.Size(67, 13);
            this.lblPotenciaL2.TabIndex = 22;
            this.lblPotenciaL2.Text = "Potencia L2:";
            // 
            // lblConsumoEstimado
            // 
            this.lblConsumoEstimado.AutoSize = true;
            this.lblConsumoEstimado.Location = new System.Drawing.Point(12, 151);
            this.lblConsumoEstimado.Name = "lblConsumoEstimado";
            this.lblConsumoEstimado.Size = new System.Drawing.Size(100, 13);
            this.lblConsumoEstimado.TabIndex = 22;
            this.lblConsumoEstimado.Text = "Consumo Estimado:";
            // 
            // lblPotenciaL3
            // 
            this.lblPotenciaL3.AutoSize = true;
            this.lblPotenciaL3.Location = new System.Drawing.Point(420, 185);
            this.lblPotenciaL3.Name = "lblPotenciaL3";
            this.lblPotenciaL3.Size = new System.Drawing.Size(67, 13);
            this.lblPotenciaL3.TabIndex = 22;
            this.lblPotenciaL3.Text = "Potencia L3:";
            // 
            // lblOrdenRuta
            // 
            this.lblOrdenRuta.AutoSize = true;
            this.lblOrdenRuta.Location = new System.Drawing.Point(299, 246);
            this.lblOrdenRuta.Name = "lblOrdenRuta";
            this.lblOrdenRuta.Size = new System.Drawing.Size(80, 13);
            this.lblOrdenRuta.TabIndex = 22;
            this.lblOrdenRuta.Text = "N° Orden Ruta:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(299, 219);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 22;
            this.lblRuta.Text = "Ruta:";
            // 
            // txtPotenciaL1
            // 
            this.txtPotenciaL1.BackColor = System.Drawing.Color.Red;
            this.txtPotenciaL1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPotenciaL1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPotenciaL1.Location = new System.Drawing.Point(85, 182);
            this.txtPotenciaL1.MaxLength = 10;
            this.txtPotenciaL1.Name = "txtPotenciaL1";
            this.txtPotenciaL1.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtPotenciaL1.Size = new System.Drawing.Size(100, 20);
            this.txtPotenciaL1.TabIndex = 2;
            this.txtPotenciaL1.TextoVacio = "<Descripcion>";
            this.txtPotenciaL1.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // txtSumNumero
            // 
            this.txtSumNumero.BackColor = System.Drawing.Color.Red;
            this.txtSumNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSumNumero.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtSumNumero.Location = new System.Drawing.Point(110, 22);
            this.txtSumNumero.MaxLength = 15;
            this.txtSumNumero.Name = "txtSumNumero";
            this.txtSumNumero.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtSumNumero.Size = new System.Drawing.Size(128, 20);
            this.txtSumNumero.TabIndex = 1;
            this.txtSumNumero.TextoVacio = "";
            this.txtSumNumero.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // cmbServicio
            // 
            this.cmbServicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbServicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(396, 22);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbServicio.Size = new System.Drawing.Size(165, 21);
            this.cmbServicio.TabIndex = 25;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(299, 30);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(48, 13);
            this.lblServicio.TabIndex = 26;
            this.lblServicio.Text = "Servicio:";
            // 
            // txtOrdenRuta
            // 
            this.txtOrdenRuta.BackColor = System.Drawing.Color.Red;
            this.txtOrdenRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrdenRuta.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtOrdenRuta.Location = new System.Drawing.Point(391, 246);
            this.txtOrdenRuta.MaxLength = 10;
            this.txtOrdenRuta.Name = "txtOrdenRuta";
            this.txtOrdenRuta.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtOrdenRuta.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenRuta.TabIndex = 2;
            this.txtOrdenRuta.TextoVacio = "<Descripcion>";
            this.txtOrdenRuta.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // lblNumeroProv
            // 
            this.lblNumeroProv.AutoSize = true;
            this.lblNumeroProv.Location = new System.Drawing.Point(107, 89);
            this.lblNumeroProv.Name = "lblNumeroProv";
            this.lblNumeroProv.Size = new System.Drawing.Size(42, 13);
            this.lblNumeroProv.TabIndex = 28;
            this.lblNumeroProv.Text = "Cliente:";
            // 
            // txtPotenciaL2
            // 
            this.txtPotenciaL2.BackColor = System.Drawing.Color.Red;
            this.txtPotenciaL2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPotenciaL2.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPotenciaL2.Location = new System.Drawing.Point(291, 182);
            this.txtPotenciaL2.MaxLength = 10;
            this.txtPotenciaL2.Name = "txtPotenciaL2";
            this.txtPotenciaL2.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtPotenciaL2.Size = new System.Drawing.Size(100, 20);
            this.txtPotenciaL2.TabIndex = 2;
            this.txtPotenciaL2.TextoVacio = "<Descripcion>";
            this.txtPotenciaL2.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // txtPotenciaL3
            // 
            this.txtPotenciaL3.BackColor = System.Drawing.Color.Red;
            this.txtPotenciaL3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPotenciaL3.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPotenciaL3.Location = new System.Drawing.Point(493, 182);
            this.txtPotenciaL3.MaxLength = 10;
            this.txtPotenciaL3.Name = "txtPotenciaL3";
            this.txtPotenciaL3.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtPotenciaL3.Size = new System.Drawing.Size(100, 20);
            this.txtPotenciaL3.TabIndex = 2;
            this.txtPotenciaL3.TextoVacio = "<Descripcion>";
            this.txtPotenciaL3.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // chkPermiteCorte
            // 
            this.chkPermiteCorte.AutoSize = true;
            this.chkPermiteCorte.Checked = true;
            this.chkPermiteCorte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPermiteCorte.Location = new System.Drawing.Point(178, 285);
            this.chkPermiteCorte.Name = "chkPermiteCorte";
            this.chkPermiteCorte.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkPermiteCorte.Size = new System.Drawing.Size(89, 17);
            this.chkPermiteCorte.TabIndex = 14;
            this.chkPermiteCorte.Text = "Permite Corte";
            this.chkPermiteCorte.UseVisualStyleBackColor = true;
            // 
            // chkPermiteFacturacion
            // 
            this.chkPermiteFacturacion.AutoSize = true;
            this.chkPermiteFacturacion.Checked = true;
            this.chkPermiteFacturacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPermiteFacturacion.Location = new System.Drawing.Point(457, 285);
            this.chkPermiteFacturacion.Name = "chkPermiteFacturacion";
            this.chkPermiteFacturacion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkPermiteFacturacion.Size = new System.Drawing.Size(120, 17);
            this.chkPermiteFacturacion.TabIndex = 14;
            this.chkPermiteFacturacion.Text = "Permite Facturación";
            this.chkPermiteFacturacion.UseVisualStyleBackColor = true;
            // 
            // chkBoxMedido
            // 
            this.chkBoxMedido.AutoSize = true;
            this.chkBoxMedido.Checked = true;
            this.chkBoxMedido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxMedido.Location = new System.Drawing.Point(332, 285);
            this.chkBoxMedido.Name = "chkBoxMedido";
            this.chkBoxMedido.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkBoxMedido.Size = new System.Drawing.Size(61, 17);
            this.chkBoxMedido.TabIndex = 14;
            this.chkBoxMedido.Text = "Medido";
            this.chkBoxMedido.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Enabled = false;
            this.btnVer.Location = new System.Drawing.Point(16, 72);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(58, 37);
            this.btnVer.TabIndex = 29;
            this.btnVer.Text = "Buscar Cliente";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // Suministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 456);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gesGroup2);
            this.Name = "Suministros";
            this.Text = "Suministros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gesGroup2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lbSumNumero;
        public Controles.contenedores.gesGroup gbDatos;
        private Controles.Fecha.dtpFecha dtpFechaAlta;
        private Controles.labels.lblEtiqueta lblTipoMedidor;
        private Controles.labels.lblEtiqueta lblFechaAlta;
        private Controles.datos.cmbLista cmbTipoConexion;
        private Controles.datos.cmbLista cmbZona;
        private Controles.textBoxes.gesTextBox txtConsumoEstimado;
        private Controles.datos.chkBox chkEstado;
        private Controles.labels.lblEtiqueta lblPotenciaL1;
        private Controles.datos.cmbLista cmbCategoria;
        private Controles.datos.cmbLista cmbRuta;
        private Controles.labels.lblEtiqueta lblTipoConexion;
        private Controles.labels.lblEtiqueta lblCategoria;
        private Controles.labels.lblEtiqueta lblPotenciaL2;
        private Controles.labels.lblEtiqueta lblConsumoEstimado;
        private Controles.labels.lblEtiqueta lblPotenciaL3;
        private Controles.labels.lblEtiqueta lblOrdenRuta;
        private Controles.labels.lblEtiqueta lblRuta;
        private Controles.textBoxes.txtDescripcionCorta txtPotenciaL1;
        private Controles.textBoxes.txtDescripcionCorta txtSumNumero;
        private Controles.datos.cmbLista cmbServicio;
        private Controles.labels.lblEtiqueta lblServicio;
        private Controles.textBoxes.txtDescripcionCorta txtOrdenRuta;
        private Controles.labels.lblEtiqueta lblNumeroProv;
        private Controles.datos.chkBox chkPermiteFacturacion;
        private Controles.datos.chkBox chkPermiteCorte;
        private Controles.datos.chkBox chkBoxMedido;
        private Controles.textBoxes.txtDescripcionCorta txtPotenciaL3;
        private Controles.textBoxes.txtDescripcionCorta txtPotenciaL2;
        private Controles.buttons.btnVer btnVer;
    }
}