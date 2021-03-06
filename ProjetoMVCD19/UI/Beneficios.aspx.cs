﻿using ProjetoMVCD19.BLL;
using ProjetoMVCD19.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD19
{
    public partial class Beneficios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                msgerro.Visible = false;
                //instanciando o DTO para armazenamento dos dados da tela
                tblClienteDTOd19 cliente = new tblClienteDTOd19();
                cliente.Email_cliente = txtEmailMVCD19.Text;
                cliente.Cpf_cliente = txtCpfMVCD19.Text;
                cliente.Nome_mae = txtnomemaeMVCD19.Text;
                //consultar o email e a senha no banco;
                BLLclientesTBLD19 bllCliente = new BLLclientesTBLD19();
                if (bllCliente.Autenticar(cliente.Email_cliente, cliente.Cpf_cliente, cliente.Nome_mae))
                {
                    msgerro.Visible = true;
                    Boolean beneficio = bllCliente.consultarBenefisio(cliente.Email_cliente);
                    if (beneficio == false)
                    {
                        msgerro.Text = "Beneficiário Não Localizado no Banco de dados.Benefício Negado";
                    }
                    else if (beneficio == true)
                    {
                        msgerro.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                    }
                }
                else
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Cliente não encontrado";
                }
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}