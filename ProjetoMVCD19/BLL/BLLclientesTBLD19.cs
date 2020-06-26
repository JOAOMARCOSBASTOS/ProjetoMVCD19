using ProjetoMVCD19.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoMVCD19.BLL
{
    public class BLLclientesTBLD19
    {
        private DALMysqlD19 daoBanco = new DALMysqlD19();

        public int Autenticar(string email, string cpf, string mae)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}' and nome_mae = '{mae}' and cpf_cliente = '{cpf}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                string buscarBeneficio = string.Format($@"select beneficio from tbl_cliente where email_cliente = '{email}' and nome_mae = '{mae}' and cpf_cliente = '{cpf}';");
                DataTable beneficio = daoBanco.ExecutarConsulta(buscarBeneficio);
                if (beneficio.Rows.Count == 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }
    }
}