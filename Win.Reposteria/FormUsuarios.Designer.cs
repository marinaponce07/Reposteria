﻿using System;

namespace Tienda
{
    partial class FormUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label tipoUsuarioLabel;
            System.Windows.Forms.Label accesaClientesLabel;
            System.Windows.Forms.Label userAdminLabel;
            System.Windows.Forms.Label accesaProductosLabel;
            System.Windows.Forms.Label accesaFacturasLabel;
            System.Windows.Forms.Label accesaReportesLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            System.Windows.Forms.Label label1;
            this.listaUsuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaUsuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.CancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.accesaClientesCheckBox = new System.Windows.Forms.CheckBox();
            this.userAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.accesaProductosCheckBox = new System.Windows.Forms.CheckBox();
            this.accesaFacturasCheckBox = new System.Windows.Forms.CheckBox();
            this.accesaReportesCheckBox = new System.Windows.Forms.CheckBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            accesaClientesLabel = new System.Windows.Forms.Label();
            userAdminLabel = new System.Windows.Forms.Label();
            accesaProductosLabel = new System.Windows.Forms.Label();
            accesaFacturasLabel = new System.Windows.Forms.Label();
            accesaReportesLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).BeginInit();
            this.listaUsuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(386, 56);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(386, 88);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 17;
            nombreLabel.Text = "Nombre:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new System.Drawing.Point(386, 120);
            contrasenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(85, 17);
            contrasenaLabel.TabIndex = 25;
            contrasenaLabel.Text = "Contrasena:";
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.Location = new System.Drawing.Point(386, 153);
            tipoUsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(113, 17);
            tipoUsuarioLabel.TabIndex = 26;
            tipoUsuarioLabel.Text = "Tipo de Usuario:";
            // 
            // accesaClientesLabel
            // 
            accesaClientesLabel.AutoSize = true;
            accesaClientesLabel.Location = new System.Drawing.Point(372, 229);
            accesaClientesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accesaClientesLabel.Name = "accesaClientesLabel";
            accesaClientesLabel.Size = new System.Drawing.Size(124, 17);
            accesaClientesLabel.TabIndex = 27;
            accesaClientesLabel.Text = "Accesa a Clientes:";
            // 
            // userAdminLabel
            // 
            userAdminLabel.AutoSize = true;
            userAdminLabel.Location = new System.Drawing.Point(374, 198);
            userAdminLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userAdminLabel.Name = "userAdminLabel";
            userAdminLabel.Size = new System.Drawing.Size(127, 17);
            userAdminLabel.TabIndex = 28;
            userAdminLabel.Text = "Es Administrador?:";
            // 
            // accesaProductosLabel
            // 
            accesaProductosLabel.AutoSize = true;
            accesaProductosLabel.Location = new System.Drawing.Point(358, 255);
            accesaProductosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accesaProductosLabel.Name = "accesaProductosLabel";
            accesaProductosLabel.Size = new System.Drawing.Size(138, 17);
            accesaProductosLabel.TabIndex = 29;
            accesaProductosLabel.Text = "Accesa a Productos:";
            // 
            // accesaFacturasLabel
            // 
            accesaFacturasLabel.AutoSize = true;
            accesaFacturasLabel.Location = new System.Drawing.Point(567, 229);
            accesaFacturasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accesaFacturasLabel.Name = "accesaFacturasLabel";
            accesaFacturasLabel.Size = new System.Drawing.Size(129, 17);
            accesaFacturasLabel.TabIndex = 30;
            accesaFacturasLabel.Text = "Accesa a Facturas:";
            // 
            // accesaReportesLabel
            // 
            accesaReportesLabel.AutoSize = true;
            accesaReportesLabel.Location = new System.Drawing.Point(564, 252);
            accesaReportesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accesaReportesLabel.Name = "accesaReportesLabel";
            accesaReportesLabel.Size = new System.Drawing.Size(132, 17);
            accesaReportesLabel.TabIndex = 31;
            accesaReportesLabel.Text = "Accesa a Reportes:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(646, 198);
            activoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 32;
            activoLabel.Text = "Activo:";
            // 
            // listaUsuariosBindingNavigator
            // 
            this.listaUsuariosBindingNavigator.AddNewItem = null;
            this.listaUsuariosBindingNavigator.BindingSource = this.listaUsuariosBindingSource;
            this.listaUsuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaUsuariosBindingNavigator.DeleteItem = null;
            this.listaUsuariosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaUsuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaUsuariosBindingNavigatorSaveItem,
            this.CancelarToolStripButton});
            this.listaUsuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaUsuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaUsuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaUsuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaUsuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaUsuariosBindingNavigator.Name = "listaUsuariosBindingNavigator";
            this.listaUsuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaUsuariosBindingNavigator.Size = new System.Drawing.Size(1126, 27);
            this.listaUsuariosBindingNavigator.TabIndex = 0;
            this.listaUsuariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaUsuariosBindingNavigatorSaveItem
            // 
            this.listaUsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaUsuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaUsuariosBindingNavigatorSaveItem.Image")));
            this.listaUsuariosBindingNavigatorSaveItem.Name = "listaUsuariosBindingNavigatorSaveItem";
            this.listaUsuariosBindingNavigatorSaveItem.RightToLeftAutoMirrorImage = true;
            this.listaUsuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaUsuariosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaUsuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaUsuariosBindingNavigatorSaveItem_Click);
            // 
            // CancelarToolStripButton
            // 
            this.CancelarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarToolStripButton.Name = "CancelarToolStripButton";
            this.CancelarToolStripButton.Size = new System.Drawing.Size(70, 24);
            this.CancelarToolStripButton.Text = "Cancelar";
            this.CancelarToolStripButton.Visible = false;
            this.CancelarToolStripButton.Click += new System.EventHandler(this.CancelarToolStripButton_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.Gray;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaUsuariosBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(828, 53);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(264, 254);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 11;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(826, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(962, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(507, 53);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(216, 22);
            this.idTextBox.TabIndex = 17;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(507, 85);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(216, 22);
            this.nombreTextBox.TabIndex = 18;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Location = new System.Drawing.Point(507, 117);
            this.contrasenaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '*';
            this.contrasenaTextBox.Size = new System.Drawing.Size(216, 22);
            this.contrasenaTextBox.TabIndex = 26;
            // 
            // tipoUsuarioComboBox
            // 
            this.tipoUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.listaUsuariosBindingSource, "TipoUsuario", true));
            this.tipoUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuarioComboBox.FormattingEnabled = true;
            this.tipoUsuarioComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Cajero",
            "Vendedor",
            "Gerente"});
            this.tipoUsuarioComboBox.Location = new System.Drawing.Point(507, 149);
            this.tipoUsuarioComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
            this.tipoUsuarioComboBox.Size = new System.Drawing.Size(216, 24);
            this.tipoUsuarioComboBox.TabIndex = 27;
            // 
            // accesaClientesCheckBox
            // 
            this.accesaClientesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "AccesaClientes", true));
            this.accesaClientesCheckBox.Location = new System.Drawing.Point(507, 223);
            this.accesaClientesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accesaClientesCheckBox.Name = "accesaClientesCheckBox";
            this.accesaClientesCheckBox.Size = new System.Drawing.Size(35, 30);
            this.accesaClientesCheckBox.TabIndex = 28;
            this.accesaClientesCheckBox.UseVisualStyleBackColor = true;
            // 
            // userAdminCheckBox
            // 
            this.userAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "UserAdmin", true));
            this.userAdminCheckBox.Location = new System.Drawing.Point(507, 192);
            this.userAdminCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userAdminCheckBox.Name = "userAdminCheckBox";
            this.userAdminCheckBox.Size = new System.Drawing.Size(35, 30);
            this.userAdminCheckBox.TabIndex = 29;
            this.userAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // accesaProductosCheckBox
            // 
            this.accesaProductosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "AccesaProductos", true));
            this.accesaProductosCheckBox.Location = new System.Drawing.Point(507, 249);
            this.accesaProductosCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accesaProductosCheckBox.Name = "accesaProductosCheckBox";
            this.accesaProductosCheckBox.Size = new System.Drawing.Size(35, 30);
            this.accesaProductosCheckBox.TabIndex = 30;
            this.accesaProductosCheckBox.UseVisualStyleBackColor = true;
            // 
            // accesaFacturasCheckBox
            // 
            this.accesaFacturasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "AccesaFacturas", true));
            this.accesaFacturasCheckBox.Location = new System.Drawing.Point(707, 223);
            this.accesaFacturasCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accesaFacturasCheckBox.Name = "accesaFacturasCheckBox";
            this.accesaFacturasCheckBox.Size = new System.Drawing.Size(35, 30);
            this.accesaFacturasCheckBox.TabIndex = 31;
            this.accesaFacturasCheckBox.UseVisualStyleBackColor = true;
            // 
            // accesaReportesCheckBox
            // 
            this.accesaReportesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "AccesaReportes", true));
            this.accesaReportesCheckBox.Location = new System.Drawing.Point(707, 246);
            this.accesaReportesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accesaReportesCheckBox.Name = "accesaReportesCheckBox";
            this.accesaReportesCheckBox.Size = new System.Drawing.Size(35, 30);
            this.accesaReportesCheckBox.TabIndex = 32;
            this.accesaReportesCheckBox.UseVisualStyleBackColor = true;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(707, 192);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(35, 30);
            this.activoCheckBox.TabIndex = 33;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(31, 268);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(267, 35);
            label1.TabIndex = 86;
            label1.Text = "Deliciosos y Sabrosos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // listaUsuariosBindingSource
            // 
            this.listaUsuariosBindingSource.DataSource = typeof(BL.Fashion.Usuario);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1126, 366);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(accesaReportesLabel);
            this.Controls.Add(this.accesaReportesCheckBox);
            this.Controls.Add(accesaFacturasLabel);
            this.Controls.Add(this.accesaFacturasCheckBox);
            this.Controls.Add(accesaProductosLabel);
            this.Controls.Add(this.accesaProductosCheckBox);
            this.Controls.Add(userAdminLabel);
            this.Controls.Add(this.userAdminCheckBox);
            this.Controls.Add(accesaClientesLabel);
            this.Controls.Add(this.accesaClientesCheckBox);
            this.Controls.Add(tipoUsuarioLabel);
            this.Controls.Add(this.tipoUsuarioComboBox);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.listaUsuariosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUsuarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.formusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).EndInit();
            this.listaUsuariosBindingNavigator.ResumeLayout(false);
            this.listaUsuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void formusuario_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
          
        }

        #endregion

        private System.Windows.Forms.BindingSource listaUsuariosBindingSource;
        private System.Windows.Forms.BindingNavigator listaUsuariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaUsuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ToolStripButton CancelarToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.ComboBox tipoUsuarioComboBox;
        private System.Windows.Forms.CheckBox accesaClientesCheckBox;
        private System.Windows.Forms.CheckBox userAdminCheckBox;
        private System.Windows.Forms.CheckBox accesaProductosCheckBox;
        private System.Windows.Forms.CheckBox accesaFacturasCheckBox;
        private System.Windows.Forms.CheckBox accesaReportesCheckBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}