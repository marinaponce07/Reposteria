using BL.Reposteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Reposteria
{
    public partial class FormProductos : Form
    {
        ProductosBL _productos;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto) listaProductosBindingSource.Current;
            // MessageBox.Show(producto);

            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");
            }
            else
            {
                    MessageBox.Show(resultado.Mensaje);
                }
            }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            Cancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if(idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {

                var id = Convert.ToInt32(idTextBox.Text);
                Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto.");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
    }
