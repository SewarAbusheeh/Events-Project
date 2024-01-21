using Azure;
using DAL.Models;
using Service.Common.Dto;
using Services.Common.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Rep
{
    public class UserRep 
    {
        private readonly CDBContext db;
        //public UserRep(CDBContext _db)
        //{
        //    //_db = db;
        //    db = _db;

        //}

        public UserRep()
        {
        }
        public List<ProviderDto> GetAllProvider()
        {
            var ProvList = new List<ProviderDto>();
            using (CDBContext dbb = new CDBContext())

            {
                var L = dbb.Providers.ToList();
                foreach (var item in L)
                {
                    ProviderDto providerDto = new ProviderDto
                    {
                        Name = item.Name,
                        Email = item.Email,
                        Id = item.ProviderId
                    };
                    ProvList.Add(providerDto);
                }
                return ProvList;
            }
        }

        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public void DeleteUser(int Id)
        {
            using (CDBContext db = new CDBContext())
            {
                var D = db.Users.Find(Id);
                db.Users.Remove(D);
                db.SaveChanges();
            }
          
        }
        public void EditUser(int Id, User user)
        {

            if (Id == user.UserId)
            {

                //    db.Users.Upadte(user);
                db.SaveChanges();
            }

        }
        public List<UserDto> GetAllUsers()
        {
            var userList = new List<UserDto>();
            using (CDBContext db = new CDBContext())
            {
                var tolist =  db.Users.ToList();

                if (tolist != null)
                {
                    foreach (var item in tolist)
                    {
                        var data = new UserDto()
                        {
                            Id = item.UserId,
                            Email = item.Email,
                            Password = item.Password,
                            ProviderId = item.ProviderId,
                            RoleId = item.RoleId,
                            UserName = item.UserName,
                            UserType = item.UserType,
                        };

                        if (item.ProviderFk == null)
                        {
                            data.ProviderName = db.Providers.Where(x => x.ProviderId == item.ProviderId).Select(x => x.Name).FirstOrDefault();
                        }

                        if (item.RoleFk == null)
                        {
                            data.RoleName = db.Roles.Where(x => x.RoleId == item.RoleId).Select(x => x.RoleName).FirstOrDefault();
                        }

                        userList.Add(data);
                    }
                }
                return userList;
            }

           
        }

        public UserDto GetUserById(int id)
        {
            using (CDBContext db = new CDBContext())
            {
               
                //  return db.Users.FirstOrDefault(x => x.UserId == id);
                var U = db.Users.Find(id);
                var tolist = db.Users.ToList().Where(a=>a.UserId==id).FirstOrDefault();
                var data = new UserDto()
                {
                    Id = tolist.UserId,
                    Email = tolist.Email,
                    Password = tolist.Password,
                    ProviderId = tolist.ProviderId,
                    RoleId = tolist.RoleId,
                    UserName = tolist.UserName,
                    UserType = tolist.UserType,
                };

                if (tolist.ProviderFk == null)  // ProviderFk --> indacties to ProviderName
                {
                    data.ProviderName = db.Providers.Where(x => x.ProviderId == tolist.ProviderId).Select(x => x.Name).FirstOrDefault();
                }

                if (tolist.RoleFk == null)
                {
                    data.RoleName = db.Roles.Where(x => x.RoleId == tolist.RoleId).Select(x => x.RoleName).FirstOrDefault();
                }

         
           
               
                return data;
            }
                
            
        }

        public bool RegisterUser(User user)
        {
            // var user = new User();


            string cs = ConfigurationManager.ConnectionStrings["newDatabaseContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                // the name of stored procuderal is asqlc
                SqlCommand sqlCommand = new SqlCommand("sqlc", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;  // tell the sqlCommand that the comming is StoredProcedure not query 
                                                                       // parameter to send to the sorted procudral 
                SqlParameter Email = new SqlParameter("@Email", user.Email);
                SqlParameter Password = new SqlParameter("@Password", user.Password);
                SqlParameter Provider = new SqlParameter("@ProviderId", user.ProviderId);
                SqlParameter Role = new SqlParameter("@RoleId", user.RoleId);

                sqlCommand.Parameters.Add(Email);
                sqlCommand.Parameters.Add(Password);
                sqlCommand.Parameters.Add(Provider);
                sqlCommand.Parameters.Add(Role);
                con.Open();
              //  sqlCommand.ExecuteScalar();  //now the command "sqlCommand" will sart to run and I use the ExecuteScalar becuse its return a first result and ignore the other 
                                             // Response.Redirect("~/Account/Login");
                int ReturnCode = (int)sqlCommand.ExecuteScalar();
                return ReturnCode == 1;
                //  int ReturnCode = (int)sqlCommand.ExecuteScalar();
                //if (ReturnCode == -1)
                //{
                //    LbMessage.Text = "This user is already exist";
                //}
                //else
                //{
                //    Response.Redirect("~/Account/Login");
                //}
            }
          
        }
        public int   loginUser(User user)   
        {
            string cs = ConfigurationManager.ConnectionStrings["newDatabaseContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("spAUTHO", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter Email = new SqlParameter("@Email", user.Email);
                SqlParameter Password = new SqlParameter("@Password", user.Password);

                sqlCommand.Parameters.Add(Email);
                sqlCommand.Parameters.Add(Password);
                //    SqlDataReader read = sqlCommand.ExecuteReader();
                int ReturnCode = (int)sqlCommand.ExecuteScalar();
                //return ReturnCode == 1;
                // return ReturnCode  ;
               // var result=0;
                //if (ReturnCode == 1)

                //{
                //    result = (int)sqlCommand.ExecuteScalar();
                //}
                return ReturnCode ;
                //if (read.Read())
                //{
                //   // Session
                //}
                //if (ReturnCode==1)
                //{
                //    HttpCon
                //}
                // string check = "SELECT UserId ,Email , Password  from [Users]  Where   user.Email =@Email and user.Password = @Password  ";
                //SqlCommand sqlchec = new SqlCommand(check, con);
                //sqlchec.Parameters.AddWithValue( "@Email", user.Email.ToString()) ;
                //sqlchec.Parameters.AddWithValue("@Password", user.Password.ToString());
                //SqlDataReader read = sqlchec.ExecuteReader();
                // string d = "";
                //if (read.Read())
                //{
                //   // Session["UserId"]= read.GetValue(0).ToString();
                //  d = read.GetValue(0).ToString();


                //}

                //  return d ;
                //SqlCommand cmd = new SqlCommand("SELECT UserId FROM USERS WHERE Email = @Email and Password=@Password", con);

                //cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
                //cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;

                //var id = cmd.ExecuteNonQuery();
                // string Query = "SELECT * FROM USERS WHERE Email = @Email and Password=@Password";
                // SqlCommand sqlCommand = new SqlCommand(Query, con);
                // sqlCommand.Parameters.AddWithValue("@Eamil",user.Email);
                // sqlCommand.Parameters.AddWithValue("@Password", user.Password);
                //int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                //if (count==1)
                //{
                //  //  Response.Redirect("Event.aspx");
                //}
                //else
                //{
                // //   MessageError.Text = "Invalid .....";

                //}

            }

        }
        public bool RegisterProviderAccount(User user)
        {
            // var user = new User();


            string cs = ConfigurationManager.ConnectionStrings["newDatabaseContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                // the name of stored procuderal is asqlc
                SqlCommand sqlCommand = new SqlCommand("RGPA", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;  // tell the sqlCommand that the comming is StoredProcedure not query 
                                                                       // parameter to send to the sorted procudral 
                SqlParameter Email = new SqlParameter("@Email", user.Email);
                SqlParameter Password = new SqlParameter("@Password", user.Password);
                SqlParameter Provider = new SqlParameter("@ProviderId", user.ProviderId);
                SqlParameter Role = new SqlParameter("@RoleId", user.RoleId);

                sqlCommand.Parameters.Add(Email);
                sqlCommand.Parameters.Add(Password);
                sqlCommand.Parameters.Add(Provider);
                sqlCommand.Parameters.Add(Role);
                con.Open();
                //  sqlCommand.ExecuteScalar();  //now the command "sqlCommand" will sart to run and I use the ExecuteScalar becuse its return a first result and ignore the other 
                // Response.Redirect("~/Account/Login");
                int ReturnCode = (int)sqlCommand.ExecuteScalar();
                return ReturnCode == 1;
                //  int ReturnCode = (int)sqlCommand.ExecuteScalar();
                //if (ReturnCode == -1)
                //{
                //    LbMessage.Text = "This user is already exist";
                //}
                //else
                //{
                //    Response.Redirect("~/Account/Login");
                //}
            }

        }
    }
}
