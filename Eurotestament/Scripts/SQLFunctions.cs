using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlConn;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using Bogus.DataSets;
using Bogus.Extensions.UnitedKingdom;
using Bogus;

namespace Eurotestament
{
    class SQLFunctions
    {
        MySqlConnection conn = DBUtils.GetDBConnection();


        public bool LoginUser(string login, string password) 
        {
            bool flag = false;
            

            string sql = String.Format("SELECT * FROM users WHERE login = @uL AND pass = @uP;");
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                flag = true;


            conn.Close();
            return flag;
        }



        public bool LoginAdmin(string login, string password)
        {
            bool flag = false;


            string sql = String.Format("SELECT * FROM admins WHERE login = @uL AND pass = @uP;");
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
                flag = true;


            conn.Close();
            return flag;
        }


        public bool RegUser(string login, string password, string name, string surname, string phone)
        {
            bool flag = false;
            var random = new Finance();
            string uId = random.Account(8);

            string sql = String.Format("INSERT INTO users(id,login,pass,name,surname,phone) VALUES (@uId,@uLogin, @uPass, @uName, @uSurname,@uPhone)");

            
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = uId;
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uSurname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phone;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }

            conn.Close();
            return flag;
        }

        public bool RegUser(string id,string login, string password, string name, string surname, string phone)
        {
            bool flag = false;


            string sql = String.Format("INSERT INTO users(id,login,pass,name,surname,phone) VALUES (@uId,@uLogin, @uPass, @uName, @uSurname,@uPhone)");


            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uSurname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phone;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }

            conn.Close();
            return flag;
        }


        public void RegUserCheck(ArrayList num, ArrayList form, ArrayList balance, ArrayList currency, string client)
        {
   
            conn.Open();

            for (int i = 0; i < num.Count; i++)
            {
                string sql = String.Format("INSERT INTO checks(num,form,balance,currency,client) VALUES (@num,@form, @balance, @currency, @client)");

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@num", MySqlDbType.VarChar).Value = num[i];
                command.Parameters.Add("@form", MySqlDbType.VarChar).Value = form[i];
                command.Parameters.Add("@balance", MySqlDbType.VarChar).Value = balance[i].ToString();
                command.Parameters.Add("@currency", MySqlDbType.VarChar).Value = currency[i];
                command.Parameters.Add("@client", MySqlDbType.VarChar).Value = client;
                command.ExecuteNonQuery();
            }

            conn.Close();
        }


        public ArrayList AllClients()
        {
            ArrayList allclients = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT id,login,name,surname,phone FROM users order by name");
            MySqlCommand command = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader sqldr = command.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclients.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            conn.Close();
            return allclients;
        }

        public DataTable AllChecksSimulat()
        {
            DataTable data = new DataTable();
            data.Clear();
            conn.Open();

            string sql = String.Format("SELECT * FROM checks ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            conn.Close();
            return data;
        }

        public ArrayList AllChecks(string userLogin)
        {
            ArrayList allchecks = new ArrayList();

            conn.Open();

            string sql = String.Format("SELECT * FROM checks WHERE client = @uID ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uID", MySqlDbType.VarChar).Value = userLogin;

            MySqlDataReader sqldr = command.ExecuteReader();
            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    allchecks.Add(result);
            }


            conn.Close();
            return allchecks;
        }



        public ArrayList AllClientsSearch(string searchtext)
        {
            ArrayList allclientssearch = new ArrayList();

            conn.Open();

            string sql = String.Format("SELECT * FROM users where " +
                "id like '%" + searchtext + "%' or " +
                "name like '%" + searchtext + "%' or " +
                "surname like '%" + searchtext + "%' or " +
                "phone like '%" + searchtext + "%'");
            MySqlCommand command = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader sqldr = command.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclientssearch.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            conn.Close();
            return allclientssearch;
        }


        public bool UpdateClientsData( string id, string name, string surname, string phone)
        {
            bool flag = false;
            conn.Open();

           
            string sql =  String.Format("update users set name = @name, surname = @surname, phone = @phone  where id = @id");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;


            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            conn.Close();
            return flag;
        }


        public bool DeleteClientsData(string id)
        {
            bool flag = false;
            conn.Open();

            string sql = String.Format("delete from users where ID = @id");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Данные Клиента невозможно удалить! Проверьте наличии зависимости данных! Иначе обратитесь разработчикам!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            conn.Close();
            return flag;
        }


        public ArrayList ClientCheck(string userId)
        {
            ArrayList allchecks = new ArrayList();

            conn.Open();

            string sql = String.Format("SELECT num,form,balance,currency  FROM checks WHERE client = @uID ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uID", MySqlDbType.VarChar).Value = userId;

            MySqlDataReader sqldr = command.ExecuteReader();
            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    allchecks.Add(result);
            }


            conn.Close();
            return allchecks;
        }

        public DataTable DataClientCheck(string id)
        {
            DataTable data = new DataTable();
            data.Clear();
            conn.Open();

            string sql = String.Format("SELECT num,form,balance,currency,client,bank FROM checks WHERE client = @uID ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uID", MySqlDbType.VarChar).Value = id;

            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);


            conn.Close();
            return data;
        }

        public bool VerificatUserBalance(string UserNumCheck, string sum)
        {
            bool flag = false;
            DataTable data = new DataTable();
            data.Clear();

            string sql = String.Format("SELECT balance FROM checks WHERE num = @uNumCheck ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uNumCheck", MySqlDbType.VarChar).Value = UserNumCheck;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            if (Convert.ToInt32(data.Rows[0][0]) >= Convert.ToInt32(sum))
                flag = true;
            else
                MessageBox.Show("Неверная сумма перевода");

            conn.Close();
            return flag;

        }

        public bool VerificatRecipientNumCheck(string RecipientNumCheck)
        {
            bool flag = false;
            DataTable data = new DataTable();
            data.Clear();

            string sql = String.Format("SELECT id FROM checks WHERE num = @uNumCheck ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uNumCheck", MySqlDbType.VarChar).Value = RecipientNumCheck;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            if (data.Rows.Count > 0)
                flag = true;
            else
                MessageBox.Show("Неверная счёт получателя");

            conn.Close();
            return flag;

        }

        public bool MoneyTransfer(string UserNumCheck, string RecipientNumCheck, string SumWriteOff, string SumCrediting, string uCurrency, string rCurrency, string rBank)
        {
            bool flag = false;
            string comission = "0";
            string total_comission = SumWriteOff;

            if (rBank != "0")
            {
                total_comission = ComissionBank("0", SumWriteOff);
                comission = (Convert.ToDouble(total_comission) - Convert.ToDouble(SumWriteOff)).ToString();

            } 


            conn.Open();
            

            string SqlUpdateUser = String.Format("update checks set balance = balance - @SumWriteOff  where num = @uNum");
            string SqlUpdateRecipient = String.Format("update checks set balance = balance + @SumCrediting  where num = @rNum");
            string SqlSendComission = String.Format("update banks_checks set balance = balance + @comissions  where id = @bankSender");

            MySqlCommand CommandUpdateUser = new MySqlCommand(SqlUpdateUser, conn);
            MySqlCommand CommandUpdateRecipient = new MySqlCommand(SqlUpdateRecipient, conn);
            MySqlCommand CommandSendComission = new MySqlCommand(SqlSendComission, conn);

            CommandUpdateUser.Parameters.Add("@SumWriteOff", MySqlDbType.VarChar).Value = total_comission;
            CommandUpdateUser.Parameters.Add("@uNum", MySqlDbType.VarChar).Value = UserNumCheck;

            CommandUpdateRecipient.Parameters.Add("@SumCrediting", MySqlDbType.VarChar).Value = SumCrediting;
            CommandUpdateRecipient.Parameters.Add("@rNum", MySqlDbType.VarChar).Value = RecipientNumCheck;
            CommandUpdateRecipient.Parameters.Add("@comission", MySqlDbType.VarChar).Value = comission;

            CommandSendComission.Parameters.Add("@comissions", MySqlDbType.VarChar).Value = comission;
            CommandSendComission.Parameters.Add("@bankSender", MySqlDbType.VarChar).Value = 0;


          

            try
            {
                if (CommandUpdateUser.ExecuteNonQuery() == 1 && CommandUpdateRecipient.ExecuteNonQuery() == 1 && CommandSendComission.ExecuteNonQuery() == 1)
                {
                    
                    if (CreateTransaction(UserNumCheck, RecipientNumCheck, total_comission, SumCrediting, uCurrency, rCurrency,  rBank,  comission, conn))
                        flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Начало Транзакции");
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            conn.Close();


            return flag;
        }



        public bool CreateTransaction(string UserNumCheck, string RecipientNumCheck, string SumWriteOff, string SumCrediting, string uCurrency, string rCurrency, string rBank, string comission, MySqlConnection conn)
        {
            bool flag = false;
            var f = new Faker();
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var TransIdentif = f.Random.Hash();


            string sql = String.Format(
                "INSERT INTO transaction(trans_identif,UserNumCheck,RecipientNumCheck,Sum_transaction,Sum_transaction_currency,Sum_enrollment,bank_recipient,Sum_enrollment_currency,date_transaction,comission) " +
                "VALUES (@tID,@uNum, @rNum, @tSum,@tCurr,@eSum,@rBank,@eCurr, @uDate,@comission)");


            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@tID", MySqlDbType.VarChar).Value = TransIdentif;
            command.Parameters.Add("@uNum", MySqlDbType.VarChar).Value = UserNumCheck;
            command.Parameters.Add("@rNum", MySqlDbType.VarChar).Value = RecipientNumCheck;
            command.Parameters.Add("@tSum", MySqlDbType.VarChar).Value = SumWriteOff;
            command.Parameters.Add("@tCurr", MySqlDbType.VarChar).Value = uCurrency;
            command.Parameters.Add("@eSum", MySqlDbType.VarChar).Value = SumCrediting;
            command.Parameters.Add("@eCurr", MySqlDbType.VarChar).Value = rCurrency;
            command.Parameters.Add("@uDate", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@rBank", MySqlDbType.VarChar).Value = rBank;
            command.Parameters.Add("@comission", MySqlDbType.VarChar).Value = comission;
            




            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }

            return flag;
        }

        public DataTable GetClient(string login) 
        {
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM users WHERE login = @uLogin ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            
            conn.Close();
            return data;
        }

        public string GetRecipienCurrency(string RecipientNumCheck)
        {
            string RecipienCurrency;
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT currency FROM checks WHERE num = @uNum ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uNum", MySqlDbType.VarChar).Value = RecipientNumCheck;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            RecipienCurrency = data.Rows[0][0].ToString();
            conn.Close();
            return RecipienCurrency;

        }

        public string GetRecipienBank(string RecipientNumCheck)
        {
            string RecipienBank;
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT bank FROM checks WHERE num = @uNum ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uNum", MySqlDbType.VarChar).Value = RecipientNumCheck;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            RecipienBank = data.Rows[0][0].ToString();
            conn.Close();
            return RecipienBank;

        }

        public string ComissionBank(string bank, string SumWriteOff) 
        {
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT comission FROM banks WHERE id = @rBank ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@rBank", MySqlDbType.VarChar).Value = bank;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            string comission_persent = data.Rows[0][0].ToString();
            string comission = ((Convert.ToDouble(SumWriteOff) * Convert.ToDouble(comission_persent)) / 100).ToString();
            string total_comission = (Convert.ToDouble(SumWriteOff) + Convert.ToDouble(comission)).ToString();



            conn.Close();
            return total_comission;

        }

        



    }
}
