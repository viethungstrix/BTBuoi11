using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BT1
{
    class Connect
    {
        public SqlConnection conn;
        public Connect()
        {
            conn = new SqlConnection("Data source=DESKTOP-CIRH81G; Initial Catalog=QLSinhVien; Integrated Security = True");
        }
        public Connect(string strcn)
        {
            conn = new SqlConnection(strcn);
        }
    }
}

/*
Thêm database tên QLSinhVien bằng MSSQL
-----------------------------------------
Create database QLSInhVien
Use QLSinhVien
go
create table SINHVIEN(
    MASV char(10) primary key,
    TENSV nvarchar(50) not null
)
-----------------------------------------
*/
