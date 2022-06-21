using FMC.Entity.Model;
using FMC.Repository.Base;
using FMC.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Repository.Concrete
{
    public class HastaRepository:BaseRepository<Hasta>
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=FMC.Repository.Context.FmcDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Hasta Add(Hasta hasta,bool hastakontrol)
        {
            Hasta hasta1 = new Hasta();
            if (hastakontrol)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.Hastas(Ad,Soyad,KimlikNo,TelefonNo,Mail,Sifre,Adres,CreatedDate,DeletedDate,Ilce_Id)VALUES(" +
                    "'" + hasta.Ad + "'," +
                    "'" + hasta.Soyad + "'," +
                    "'" + hasta.KimlikNo + "'," +
                     "'" + hasta.TelefonNo + "'," +
                      "'" + hasta.Mail + "'," +
                       "'" + hasta.Sifre + "'," +
                        "'" + hasta.Adres + "'," +
                         "'" + hasta.CreatedDate + "'," +
                          "'" + hasta.DeletedDate + "'," +
                           "'" + hasta.Ilce.Id + "'" +
                    ");",sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return hasta1;
        }
    }
}
