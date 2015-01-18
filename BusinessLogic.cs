using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using LibraryDesign_frontEndUI;

namespace LibraryDesign_frontEndUI
{
    class BusinessLogic
    {

        private string _strconnectionString = string.Empty;
        private  SqlConnection  _sqlConnection = null;

        public BusinessLogic()
        {
            _strconnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            _sqlConnection = new SqlConnection(_strconnectionString);
        }

        internal void GetSuppliers(BLSSchema bLSSchema)
        {
            _sqlConnection.Open();
            bLSSchema.ctSup.Clear();
            SqlCommand cmd = new SqlCommand("up_usr_select_Suppliers", _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.Add("@CategoryID", SqlDbType.BigInt, 10).Value = CategoryID;
            
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //_sqlConnection.Open();
            adp.Fill(bLSSchema.ctSup);
            _sqlConnection.Close();

                     
           
        }

        internal void AddStock(DataTable dtStock,string strTitle,string strAuthor,string strEdition,float fltPice, int intCount)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_Stock", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = fltPice;
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intCount;
                cmd.Parameters.Add("@StockTable", SqlDbType.Structured).Value = dtStock;
                cmd.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding stock to the database.   Error  :" + ex);
            }
            
        }

        internal void AddOutStock(DataTable dtStock, string strTitle,string strAuthor,string strEdition,float fltPice, int intCount)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_OutStock", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = fltPice;
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intCount;
                cmd.Parameters.Add("@StockTable", SqlDbType.Structured).Value = dtStock;
                cmd.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding stock to the database.   Error  :" + ex);
            }

        }

        internal void PlaceOrder(DataTable dtOrder, string strISBN, string strCustomerID,int intBookCount)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_Order", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = strISBN;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@Count", SqlDbType.Int).Value = intBookCount;
                cmd.Parameters.Add("@OrderTable", SqlDbType.Structured).Value = dtOrder;
                cmd.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal bool AddCustomer(DataTable dtCustomer, string strMobile, string strFirstName)
        {
            bool blnAddStatus = false;
            try
            {
                SqlCommand Cmd = new SqlCommand("up_usr_insert_Customer", _sqlConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = strFirstName;
                Cmd.Parameters.Add("@Mobile", SqlDbType.VarChar).Value = strMobile;
                Cmd.Parameters.Add("@CustTable", SqlDbType.Structured).Value = dtCustomer;
                SqlParameter outputCount = new SqlParameter("@Status", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                Cmd.Parameters.Add(outputCount);
                _sqlConnection.Open();

                Cmd.ExecuteNonQuery();

                _sqlConnection.Close();

                return (bool.Parse(outputCount.Value.ToString()));
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding stock to the database.   Error  :" + ex);
            }

        }

        internal BLSSchema GetStock(BLSSchema bLSSchema, string strQuery)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = _sqlConnection.CreateCommand();
                cmd.CommandText = strQuery;
                da.SelectCommand = cmd;
                bLSSchema.ctStockSearch.Clear();
                _sqlConnection.Open();
                da.Fill(bLSSchema.ctStockSearch);
                _sqlConnection.Close();
                
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw new ApplicationException(ex.ToString());
            }

            return bLSSchema;
        }

        internal BLSSchema GetCustomer(BLSSchema bLSSchema, string strQuery)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = _sqlConnection.CreateCommand();
                cmd.CommandText = strQuery;
                da.SelectCommand = cmd;
                bLSSchema.ctCustomer.Clear();
                _sqlConnection.Open();
                da.Fill(bLSSchema.ctCustomer);
                _sqlConnection.Close();

            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw new ApplicationException(ex.ToString());
            }

            return bLSSchema;
        }

        internal BLSSchema GetOrders(BLSSchema bLSSchema, string strQuery)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = _sqlConnection.CreateCommand();
                cmd.CommandText = strQuery;
                da.SelectCommand = cmd;
                bLSSchema.ctOrders.Clear();
                _sqlConnection.Open();
                da.Fill(bLSSchema.ctOrders);
                _sqlConnection.Close();

            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw new ApplicationException(ex.ToString());
            }

            return bLSSchema;
        }
        
        internal bool  AddHistory(DataTable dtHistory, Guid id)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_History", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id.ToString();
                SqlParameter outputIdParam = new SqlParameter("@RowCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.Parameters.Add("@TransactionTable", SqlDbType.Structured).Value = dtHistory;
                cmd.ExecuteNonQuery();
                int intReturnValue = int.Parse(outputIdParam.Value.ToString()); //TODO:Get the return value from the Stored Procedure. 
                if (intReturnValue > 0)
                {
                    _sqlConnection.Close();
                    return false;
                }
                else
                {
                    _sqlConnection.Close();
                    return true;
                }
               
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal void GetIssueDetails(BLSSchema bLSSchema, string strCustID)
        {
            try
            {
                _sqlConnection.Open();
                bLSSchema.ctIssueBookList.Clear();
                SqlCommand cmd = new SqlCommand("up_usr_select_UserIssues", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustID", SqlDbType.VarChar, 20).Value = strCustID;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);                
                adp.Fill(bLSSchema.ctIssueBookList);
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal void GetIssueDetails(BLSSchema.ctIssueBookListDataTable dtIssuedBooks, string strCustID)
        {
            try
            {
                _sqlConnection.Open();
                dtIssuedBooks.Clear();
                SqlCommand cmd = new SqlCommand("up_usr_select_UserIssues", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustID", SqlDbType.VarChar, 20).Value = strCustID;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dtIssuedBooks);
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }
        
        internal bool AddIssue(DataTable dtIssue, string strCustomerID ,string strTitle,string strAuthor,
            string strEdition, float fltPrice,DateTime dtIssueDate)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_Issue", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = int.Parse(strCustomerID);
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
                cmd.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = dtIssueDate;
                SqlParameter outputIdParam = new SqlParameter("@RowCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.Parameters.Add("@IssueTable", SqlDbType.Structured).Value = dtIssue;
                cmd.ExecuteNonQuery();
                int intReturnValue = int.Parse(outputIdParam.Value.ToString()); 
                if (intReturnValue > 0)
                {
                    _sqlConnection.Close();
                    return false;
                }
                else
                {
                    _sqlConnection.Close();
                    return true;
                }
               
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding issue.\nError  :" + ex);
            }

        }

        internal void UpdateStock(string strType, string strTitle,string strAuthor,string strEdition,
            string strPublisher,float fltPice,int intBookCount)
        {
            try
            {
                _sqlConnection.Open();
                if (strType == "Issue")
                {
                    SqlCommand cmd = new SqlCommand("up_usr_Update_Stock", _sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                    cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                    cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                    cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                    cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPice; 
                    cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = -(intBookCount);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("up_usr_Update_Stock", _sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                    cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                    cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                    cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                    cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPice; 
                    cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                    cmd.ExecuteNonQuery();
                }
                
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }
            
                     
                
        
        internal void UpdateCustomer(string strType,string strMemberShipType, string strCustomerID, int intBookCount,
            float fltAdvance,float fltBalance,float fltLimitUsed)
        {
            try
            {
                _sqlConnection.Open();
                if (strType == "Issue")
                {
                    SqlCommand cmd = new SqlCommand("up_usr_Update_Customer", _sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                    cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                    cmd.Parameters.Add("@AdvanceAmount", SqlDbType.Float).Value = fltAdvance;
                    cmd.Parameters.Add("@BalanceAmount", SqlDbType.Float).Value = fltBalance;
                    if (strMemberShipType == "R" || strMemberShipType == "O")
                    {
                        cmd.Parameters.Add("@LimitUsed", SqlDbType.Float).Value = -1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@LimitUsed", SqlDbType.Float).Value = fltLimitUsed;
                        
                    }
                    cmd.ExecuteNonQuery();
                }
                else//Return
                {
                    SqlCommand cmd = new SqlCommand("up_usr_Update_Customer", _sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                    cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = -(intBookCount);
                    cmd.ExecuteNonQuery();
                }

                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal BLSSchema GetHistory(BLSSchema bLSSchema, string strQuery)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = _sqlConnection.CreateCommand();
                cmd.CommandText = strQuery;
                da.SelectCommand = cmd;
                bLSSchema.ctTransactionHistory.Clear();
                _sqlConnection.Open();
                da.Fill(bLSSchema.ctTransactionHistory);
                _sqlConnection.Close();

            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw new ApplicationException(ex.ToString());
            }

            return bLSSchema;
        }

        internal int GetCustomerID(int intStartValue)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_select_customerID", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StartValue", SqlDbType.Int).Value = intStartValue;
                SqlParameter outputIdParam = new SqlParameter("@ID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.ExecuteNonQuery();
                int intReturnValue = intStartValue;
                if(string.IsNullOrWhiteSpace(outputIdParam.Value.ToString())!= true)
                {
                    if (outputIdParam.Value.ToString().Length >= 8)
                    {
                        intReturnValue = int.Parse(outputIdParam.Value.ToString().Substring(6, 4));
                    }
                } 
                _sqlConnection.Close();
                return intReturnValue + 1;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while getting new customer ID.\nError  :" + ex);
            }
        }

        internal int GetCustomerBooksID()
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_select_CustomerBookID", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter outputIdParam = new SqlParameter("@ID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.ExecuteNonQuery();
                int intReturnValue = 0;
                if (string.IsNullOrWhiteSpace(outputIdParam.Value.ToString()) != true)
                {
                    intReturnValue = int.Parse(outputIdParam.Value.ToString());
                }
                _sqlConnection.Close();
                return intReturnValue + 1;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while getting new customer ID.\nError  :" + ex);
            }
        }

        internal string GetReceiptNumber()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("up_usr_select_ReceiptNumber", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ReceiptNumber", SqlDbType.VarChar, 10);
                cmd.Parameters["@ReceiptNumber"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                string strRecieptNumber = cmd.Parameters["@ReceiptNumber"].Value.ToString();
                _sqlConnection.Close();

                string strNewNumber = string.Empty;
                if (string.IsNullOrWhiteSpace(strRecieptNumber) == true)
                {
                    strNewNumber = "TRLND" + "00001";
                }
                else
                {
                    int intNumber = int.Parse(strRecieptNumber.Substring(5, 5));
                    intNumber++;

                    strNewNumber = strRecieptNumber.Substring(0, 5) + intNumber.ToString().PadLeft(5, '0');

                }

                return strNewNumber;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while getting new customer ID.\nError  :" + ex);
            }
            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        internal void InsertReceipt(string strReceiptNumber, string strUID)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_Receipt", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ReceiptNumber", SqlDbType.VarChar).Value = strReceiptNumber;
                cmd.Parameters.Add("@ReceiptDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@HistoryID", SqlDbType.VarChar).Value = strUID;
                cmd.Parameters.Add("@printedFlag", SqlDbType.Bit).Value = false;
                cmd.ExecuteNonQuery();
                _sqlConnection.Close();
               

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding receipt.\nError  :" + ex);
            }
        }

        internal void AddCustomerBookDetails(DataTable dtCustomerBookDetails,string strTitle,
            string strAuthor,string strEdition,float fltPrice,int intCount)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_insert_CustomerBooks", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustBooksTable", SqlDbType.Structured).Value = dtCustomerBookDetails;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = fltPrice;
                cmd.Parameters.Add("@Count", SqlDbType.Int).Value = intCount;
                cmd.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding Customer Book details to the database.   Error  :" + ex);
            }

        }

        internal float[] GetLimit(string strCustomerID)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Select_GetCustomerLimits", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = strCustomerID;
                SqlParameter outputMaxLimit = new SqlParameter("@MaxLimit", SqlDbType.Float)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputMaxLimit);

                SqlParameter outputLimitUsed = new SqlParameter("@LimitUsed", SqlDbType.Float)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputLimitUsed);

                cmd.ExecuteNonQuery();

                float fltMaxLimit = (outputMaxLimit.Value == DBNull.Value) ? 0 : float.Parse(outputMaxLimit.Value.ToString());
                float fltLimitUsed = (outputLimitUsed.Value == DBNull.Value) ? 0 : float.Parse(outputLimitUsed.Value.ToString());

                float[] fltItems = new float[2];
                fltItems[0] = fltMaxLimit;
                fltItems[1] = fltLimitUsed;

                return fltItems;

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while retrieving customer limits.\nError  : " + ex);
            }

        }

        internal bool DeleteIssue(string strTitle, string strAuthor, string strEdition, 
            string strPublisher,float fltBookPrice,string strCustomerID,string strUID)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Delete_Issue", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltBookPrice;
                cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = strUID;
                SqlParameter outputCount = new SqlParameter("@Status", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputCount);
                cmd.ExecuteNonQuery();               

                int intCount = int.Parse(outputCount.Value.ToString());
                if (intCount > 0)
                {
                    _sqlConnection.Close();
                    return true;
                }
                else
                {
                    _sqlConnection.Close();
                    return false;

                }
               
               
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal void UpdateCustomerLimit(string strCustomerID, float fltPrice,int intBookCount)
        {
            try
            {
                
                _sqlConnection.Open();
                
                    SqlCommand cmd = new SqlCommand("up_usr_Update_Limit", _sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                    cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                    cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;                    
                    cmd.ExecuteNonQuery();                

                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal void UpdateCustomerForRentalReturn(string strCustomerID, float fltPrice, int intBookCount,float fltAdvance,float fltBalance)
        {
            try
            {

                _sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("up_usr_Update_CustomerDetailsOnReturn", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
                cmd.Parameters.Add("@Advance", SqlDbType.Float).Value = fltAdvance;
                cmd.Parameters.Add("@Balance", SqlDbType.Float).Value = fltBalance;
                cmd.ExecuteNonQuery();

                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        internal bool UpdateCustomerDetails(string strCustomerID, DataTable dtCustomer)
        {
            try
            {

                _sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("up_usr_Update_CustomerDetails", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@CustomerTable", SqlDbType.Structured).Value = dtCustomer;
                SqlParameter outputCount = new SqlParameter("@RowCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputCount);
                cmd.ExecuteNonQuery();
                int intCount = int.Parse(outputCount.Value.ToString());
                if (intCount > 0)
                {
                    _sqlConnection.Close();
                    return true;
                }
                else
                {
                    _sqlConnection.Close();
                    return false;

                }

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

            finally
            {
                _sqlConnection.Close();
            }

        }

        internal void UpdatestockDetails(string strTitle,string strAuthor,string strEdition,
            float stroldPurchasePrice,float purchasedprice, DataTable dtstock)
        {
            try
            {

                _sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("up_usr_Update_StockDtail", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strTitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@oldPurchasePrice", SqlDbType.Float).Value = stroldPurchasePrice;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = purchasedprice;
                cmd.Parameters.Add("@StockTable", SqlDbType.Structured).Value = dtstock;
                cmd.ExecuteNonQuery();                

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while updating stock details.\nError  :" + ex);
            }

            finally
            {
                _sqlConnection.Close();
            }

        }


        internal bool DeleteCustomer(string strCustomerID)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Delete_Customer_details", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;               
                SqlParameter outputCount = new SqlParameter("@Status", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputCount);
                cmd.ExecuteNonQuery();

                int intCount = int.Parse(outputCount.Value.ToString());
                if (intCount > 0)
                {
                    _sqlConnection.Close();
                    return true;
                }
                else
                {
                    _sqlConnection.Close();
                    return false;

                }


            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while deleting customer.\nError  :" + ex);
            }

        }

        internal bool Deletestock(string strtitle, string strAuthor, string strEdition,float fltPrice)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Delete_stock", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = fltPrice;
                SqlParameter outputCount = new SqlParameter("@Status", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputCount);
                cmd.ExecuteNonQuery();

                int intCount = int.Parse(outputCount.Value.ToString());
                if (intCount > 0)
                {
                    _sqlConnection.Close();
                    return true;
                }
                else
                {
                    _sqlConnection.Close();
                    return false;

                }


            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while deleting customer.\nError  :" + ex);
            }

        }

        internal void SearchBooksBorrowed(ref  BLSSchema.ctIssueDataTable _dtIssue, int _intCustID)
        {
            try
            {
                if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }
                 SqlCommand cmd = new SqlCommand("up_usr_select_UserEarlyIssues", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustID", SqlDbType.Int).Value = _intCustID;         
                SqlDataAdapter da = new SqlDataAdapter();               
                da.SelectCommand = cmd;
                _dtIssue.Clear();              
                da.Fill(_dtIssue);
                _sqlConnection.Close();

            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw new ApplicationException(ex.ToString());
            }
        }

        internal bool IsCustomerExist(string strCustID)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Check_Customer_Exist", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar, 20).Value = strCustID;
                SqlParameter outputCount = new SqlParameter("@RowCount", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputCount);                

                cmd.ExecuteNonQuery();
               
                return (bool.Parse(outputCount.Value.ToString()));


            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }
            finally
            {
                _sqlConnection.Close();
            }

        }

        # region [Latest Implimentations]

        internal bool PerformEarlyIssueProcess(string strCustomerID,int intCount, DateTime dtIssueDate, float fltAdvanceAmount,
            float fltBalanceAmount, float fltLimitUsed, DataTable dtStock, DataTable dtIssue)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("up_usr_Execute_EarlyIssue", _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
            cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intCount;
            cmd.Parameters.Add("@AdvanceAmount", SqlDbType.Float).Value = fltAdvanceAmount;
            cmd.Parameters.Add("@BalanceAmount", SqlDbType.Float).Value = fltBalanceAmount;
            cmd.Parameters.Add("@LimitUsed", SqlDbType.Float).Value = fltLimitUsed;
            cmd.Parameters.Add("@StockTable", SqlDbType.Structured).Value = dtStock;
            cmd.Parameters.Add("@IssueTable", SqlDbType.Structured).Value = dtIssue;
            SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputIdParam);
            cmd.ExecuteNonQuery();
            return (bool.Parse(outputIdParam.Value.ToString()));

        }


        internal bool PerformReturnProcess(string strCustomerID, string strtitle, string strAuthor, string strEdition,
           string strPublisher, float fltPrice, string strHistoryUID, int intBookCount)
        {
            if (_sqlConnection.State != ConnectionState.Open)
            {
                _sqlConnection.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("up_usr_Execute_Return", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
                cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = strHistoryUID;
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                cmd.Parameters.Add("@AmountOut", SqlDbType.Float).Value = 0;
                SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.ExecuteNonQuery();
                return (bool.Parse(outputIdParam.Value.ToString()));
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
               
            }
        }

        internal bool PerformReturnProcessForRental(string strCustomerID, string strtitle, string strAuthor, 
            string strEdition, string strPublisher,float fltPrice, string strHistoryUID, int intBookCount,
            float fltAdvanceAmount,float fltBalanceAmount,float fltRefundAmount,string strCheckNumber)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Execute_Return_Rental", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
                cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = strHistoryUID;
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                cmd.Parameters.Add("@AdvanceAmount", SqlDbType.Float).Value = fltAdvanceAmount;
                cmd.Parameters.Add("@BalanceAmount", SqlDbType.Float).Value = fltBalanceAmount;
                cmd.Parameters.Add("@RefundAmount", SqlDbType.Float).Value = fltRefundAmount;
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar).Value = strCheckNumber;                
                SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.ExecuteNonQuery();
                return (bool.Parse(outputIdParam.Value.ToString()));
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                _sqlConnection.Close();                
            }
            return false;
        }

        internal bool PerformReturnProcessForOther(string strCustomerID, string strtitle, string strAuthor, 
            string strEdition,string strPublisher,float fltPrice, string strHistoryUID, int intBookCount, 
            float fltAdvanceAmount, float fltBalanceAmount)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("up_usr_Execute_Return_Other", _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
            cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
            cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
            cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
            cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = strHistoryUID;
            cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
            cmd.Parameters.Add("@AdvanceAmount", SqlDbType.Float).Value = fltAdvanceAmount;
            cmd.Parameters.Add("@BalanceAmount", SqlDbType.Float).Value = fltBalanceAmount;
            SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputIdParam);
            cmd.ExecuteNonQuery();
            return (bool.Parse(outputIdParam.Value.ToString()));
        }


        internal bool PerformRegularIssueProcess(float fltAdvanceAmount, float fltBalanceAmount,
            float fltLimitUsed, DataTable dtTransactionHiustory, DataTable dtIssue)
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("up_usr_Execute_Regular_Issue", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["CustomerID"];
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Title"];
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Author"];
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Edition"];
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Publisher"];
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = float.Parse(dtIssue.Rows[0]["BookPrice"].ToString());
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = dtTransactionHiustory.Rows[0]["IssueDate"]; ;
                cmd.Parameters.Add("@AdvanceAmount", SqlDbType.Float).Value = fltAdvanceAmount;
                cmd.Parameters.Add("@BalanceAmount", SqlDbType.Float).Value = fltBalanceAmount;
                cmd.Parameters.Add("@LimitUsed", SqlDbType.Float).Value = fltLimitUsed;
                cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["HistoryUID"]; ;
                cmd.Parameters.Add("@TransactionTable", SqlDbType.Structured).Value = dtTransactionHiustory;
                cmd.Parameters.Add("@IssueTable", SqlDbType.Structured).Value = dtIssue;
                SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.ExecuteNonQuery();
                if ((bool.Parse(outputIdParam.Value.ToString())))
                {
                    return true;
                }
                else
                {
                    throw new ApplicationException("Error while issuing book");
                }
            }
            catch (SqlException SqlEx)
            {
                throw new ApplicationException(SqlEx.ToString());
            }
            catch (Exception Ex)
            {
                throw new ApplicationException(Ex.ToString());
            }
            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                   _sqlConnection.Close();
                }
            }

        }


        internal bool PerformRegularIssueNonRentalProcess(DataTable dtTransactionHiustory, DataTable dtIssue)
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("up_usr_Execute_Regular_Issue_FOr_NonRental", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["CustomerID"];
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Title"];
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Author"];
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Edition"];
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["Publisher"];
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = float.Parse(dtIssue.Rows[0]["BookPrice"].ToString());
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = dtTransactionHiustory.Rows[0]["IssueDate"]; ;
                cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = dtTransactionHiustory.Rows[0]["HistoryUID"]; ;
                cmd.Parameters.Add("@TransactionTable", SqlDbType.Structured).Value = dtTransactionHiustory;
                cmd.Parameters.Add("@IssueTable", SqlDbType.Structured).Value = dtIssue;
                SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cmd.ExecuteNonQuery();
                if ((bool.Parse(outputIdParam.Value.ToString())))
                {
                    return true;
                }
                else
                {
                    throw new ApplicationException("Error while issuing book");
                }
            }
            catch (SqlException SqlEx)
            {
                throw new ApplicationException(SqlEx.ToString());
            }
            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        internal bool DeleteIssuedBookEntries_NonRental(string strCustomerID, string strtitle, string strAuthor, 
            string strEdition,string strPublisher,float fltPrice, string strHistoryUID, int intBookCount,
            bool blnEarlyIssue)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("up_usr_Undo_Issue_NonRental", _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
            cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
            cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
            cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
            cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = strHistoryUID;
            cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
            cmd.Parameters.Add("@EarlyIssue", SqlDbType.Bit).Value = blnEarlyIssue;
            
            SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputIdParam);
            cmd.ExecuteNonQuery();
            return (bool.Parse(outputIdParam.Value.ToString()));
        }


        internal bool DeleteIssuedBookEntries_Rental(string strCustomerID, string strtitle, string strAuthor, 
            string strEdition,string strPublisher,float fltPrice, string strHistoryUID, int intBookCount,
            bool blnEarlyIssue)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("up_usr_Undo_Issue_Rental", _sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
            cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
            cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
            cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
            cmd.Parameters.Add("@HistoryUID", SqlDbType.VarChar).Value = strHistoryUID;
            cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
            cmd.Parameters.Add("@EarlyIssue", SqlDbType.Bit).Value = blnEarlyIssue;

            SqlParameter outputIdParam = new SqlParameter("@Status", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputIdParam);
            cmd.ExecuteNonQuery();
            return (bool.Parse(outputIdParam.Value.ToString()));
        }


        internal bool CheckDuplicateIssue(int strCustomerID ,string strtitle, string strAuthor, string strEdition,
            string strPublisher ,float fltPrice)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Get_Issue_Count", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = strCustomerID;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
                //cmd.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = dtIssueDate;
                SqlParameter outputIdParam = new SqlParameter("@RowCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);                
                cmd.ExecuteNonQuery();
                int intReturnValue = int.Parse(outputIdParam.Value.ToString());
                if (intReturnValue > 0)
                {
                    _sqlConnection.Close();
                    return true;
                }
                else
                {
                    _sqlConnection.Close();
                    return false;
                }

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding issue.\nError  :" + ex);
            }
        }

        internal string CheckStockExists(string strtitle, string strAuthor, string strEdition, string strPublisher, float fltPrice)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Stock_Exist", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = strtitle;
                cmd.Parameters.Add("@Author", SqlDbType.VarChar).Value = strAuthor;
                cmd.Parameters.Add("@Edition", SqlDbType.VarChar).Value = strEdition;
                cmd.Parameters.Add("@Publisher", SqlDbType.VarChar).Value = strPublisher;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = fltPrice;
                //cmd.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = dtIssueDate;
                SqlParameter outputIdParam = new SqlParameter("@RowCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                SqlParameter outputBookNumParam = new SqlParameter("@Book_Number", SqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputBookNumParam);
                cmd.ExecuteNonQuery();
                int intReturnValue = int.Parse(outputIdParam.Value.ToString());
                if (intReturnValue > 0)
                {
                    return outputBookNumParam.ToString();
                }
                else
                {

                    return string.Empty;
                }

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while adding issue.\nError  :" + ex);
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        internal void GetEarlyIssueDetails(BLSSchema.ctStockDataTable dtTempStock, int intCustID)
        {
            try
            {
                _sqlConnection.Open();
                dtTempStock.Clear();
                SqlCommand cmd = new SqlCommand("up_usr_select_UserIssues", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustID", SqlDbType.Int, 12).Value = intCustID;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dtTempStock);
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while placing order.\nError  :" + ex);
            }

        }

        #endregion

        #region Register customer auto completion methods

        internal BLSSchema.ctCustomerForAutoCompleteDataTable SearchCustomerDetail(string strFilterName, string strFilterValue)
        {
            BLSSchema.ctCustomerForAutoCompleteDataTable ctCust = new BLSSchema.ctCustomerForAutoCompleteDataTable();
            try
            {
                if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }
                SqlCommand cmd = new SqlCommand("up_usr_select_customerDetailsForAutoComplete", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FilterName", SqlDbType.VarChar).Value = strFilterName;
                cmd.Parameters.Add("@FilterValue", SqlDbType.VarChar).Value = strFilterValue;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;               
                da.Fill(ctCust);

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                _sqlConnection.Close();
            }

            return ctCust;
        }

        #endregion


        internal void AddCheckDetails(string strCustomerID,string strCheckNumber,
            string strCheckAmount, string strCheckClearanceDate)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("up_usr_Execute_Insert_Check_Details", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar).Value = strCheckNumber;
                cmd.Parameters.Add("@CheckAmount", SqlDbType.Float).Value = float.Parse(strCheckAmount);
                cmd.Parameters.Add("@ClearanceDate", SqlDbType.Date).Value = DateTime.Parse(strCheckClearanceDate);
                cmd.Parameters.Add("@CheckIssueDate", SqlDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("@CheckStatus", SqlDbType.VarChar).Value = "PNDNG";           
                cmd.ExecuteNonQuery();                
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                _sqlConnection.Close();
            }
           
        }

        internal void UpdateCustomerForNonRentalIssue(string strCustomerID, int intBookCount, float fltLimitUsed)
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("up_usr_Update_CustomerDetailsOnNonRentalIssue", _sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = strCustomerID;
                cmd.Parameters.Add("@BookCount", SqlDbType.Int).Value = intBookCount;
                cmd.Parameters.Add("@LimitUsed", SqlDbType.Float).Value = fltLimitUsed;
                cmd.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error occured while Updating customer.\nError  :" + ex);
            }
            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

        }
    }
}
