using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    class CNhanVien
    {
        private string m_Code;
        private string m_Ten;
        private double m_Luong;
        private string m_LoaiNV;

        

        public string code { get => m_Code; set => m_Code = value; }
        public string name { get => m_Ten; set => m_Ten = value; }
        public double luong { get => m_Luong; set => m_Luong = value; }
        public string LoaiNV { get => m_LoaiNV; set => m_LoaiNV = value; }

        public CNhanVien()
        {
            m_Code = string.Empty;
            m_Ten = string.Empty;
            m_Luong = 0.0;
            LoaiNV = string.Empty;
        }
        public CNhanVien(string code,string name, double luong,string loainv)
        {
            m_Code = code;
            m_Ten = name;
            m_Luong =luong;
            m_LoaiNV = loainv;
        }
        //public override string ToString()
        //{
        //    return code+"-"+name+"-"+luong;
        //}
    }

}
