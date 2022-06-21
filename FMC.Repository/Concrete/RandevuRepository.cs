using FMC.Entity.Model;
using FMC.Repository.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Repository.Concrete
{
    public class RandevuRepository : BaseRepository<Randevu>
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=FMC.Repository.Context.FmcDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Randevu Add(Randevu randevu, bool randevukontrol)
        {
            Randevu randevu1 = new Randevu();
            if (randevukontrol)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.Randevus(Aktif,Tarih,CreatedDate,DeletedDate,Doktor_Id,Hasta_Id)VALUES(" +
                    "'" + randevu.Aktif + "'," +
                    "'" + randevu.Tarih + "'," +
                    "'" + randevu.CreatedDate + "'," +
                    "'" + randevu.DeletedDate + "'," +
                     "'" + randevu.Doktor.Id + "'," +
                      "'" + randevu.Hasta.Id + "'" +
                    ");", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return randevu1;
        }
    }
}
