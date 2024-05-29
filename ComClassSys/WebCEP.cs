using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ComClassSys
{
    public class WebCEP
    {
        #region "Váriavies"  
        string _uf;
        string _cidade;
        string _bairro;
        string _tipo_lagradouro;
        string _lagradouro;
        string _resultado;
        string _resultato_txt;
        #endregion

        #region "Propiedades"  
        public string UF
        {
            get { return _uf; }
        }
        public string Cidade
        {
            get { return _cidade; }
        }
        public string Bairro
        {
            get { return _bairro; }
        }
        public string TipoLagradouro
        {
            get { return _tipo_lagradouro; }
        }
        public string Lagradouro
        {
            get { return _lagradouro; }
        }
        public string Resultado
        {
            get { return _resultado; }
        }
        public string ResultadoTXT
        {
            get { return _resultato_txt; }
        }
        #endregion
        #region "Construtor"  
        /// <summary>  
        /// WebService para Busca de CEP  
        ///  </summary>  
        /// <param  name="CEP"></param>  
        public WebCEP(string CEP)
        {
            _uf = "";
            _cidade = "";
            _bairro = "";
            _tipo_lagradouro = "";
            _lagradouro = "";
            _resultado = "0";
            _resultato_txt = "CEP não encontrado";

            //Cria um DataSet  baseado no retorno do XML  
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP.Replace("-", "").Trim() + "&formato=xml");

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _resultado = ds.Tables[0].Rows[0]["resultado"].ToString();
                    switch (_resultado)
                    {
                        case "1":
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _cidade = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            _tipo_lagradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                            _lagradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                            _resultato_txt = "CEP completo";
                            break;
                        case "2":
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _cidade = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            _bairro = "";
                            _tipo_lagradouro = "";
                            _lagradouro = "";
                            _resultato_txt = "CEP  único";
                            break;
                        default:
                            _uf = "";
                            _cidade = "";
                            _bairro = "";
                            _tipo_lagradouro = "";
                            _lagradouro = "";
                            _resultato_txt = "CEP não  encontrado";
                            break;
                    }
                }
            }
            //Exemplo do retorno da  WEB  
            //<?xml version="1.0"  encoding="iso-8859-1"?>  
            //<webservicecep>  
            //<uf>RS</uf>  
            //<cidade>Porto  Alegre</cidade>  
            //<bairro>Passo  D'Areia</bairro>  
            //<tipo_logradouro>Avenida</tipo_logradouro>  
            //<logradouro>Assis Brasil</logradouro>  
            //<resultado>1</resultado>  
            //<resultado_txt>sucesso - cep  completo</resultado_txt>  
            //</webservicecep>  
        }
        #endregion

    }
}
