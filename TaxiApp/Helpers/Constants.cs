﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiApp.Models;

namespace TaxiApp.Helpers
{
    public class Constants
    {
        #region Singleton
        private static Constants instance;

        public static Constants Instance
        {
            get
            {
                if (instance == null)
                    instance = new Constants();
                return instance;
            }
        }

        private Constants() { }
        #endregion

        private List<AccountStatus> Statuses;
        private List<DiscountModel> Discounts;

        public readonly string DBConnectionString = "Server=.\\SQLEXPRESS;Database=TaxiDB;Trusted_Connection=true";
        public string Status;

        public List<BrandModel> Brands;
        public List<ColorsModel> Colors;

        public void InitializeConstants()
        {
            this.Status = string.Empty;
            LoadStatuses();
            LoadDiscounts();
            LoadBrands();
            LoadColors();
        }

        private void LoadStatuses()
        {
            Statuses = new List<AccountStatus>();

            using (var connection = new SqlConnection(DBConnectionString))
            {
                try
                {
                    const string query = "Select * From AccountStatus";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Statuses.Add(new AccountStatus()
                        {
                            Id = Convert.ToInt32(dr["StatusId"]),
                            Name = dr["Name"].ToString()
                        });
                    }
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadDiscounts()
        {
            Discounts = new List<DiscountModel>();

            using (var connection = new SqlConnection(DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Discounts";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Discounts.Add(new DiscountModel()
                        {
                            Id = Convert.ToInt32(dr["DiscountId"]),
                            Name = dr["Name"].ToString(),
                            PercentSize = Convert.ToInt32(dr["PercentSize"])
                        });
                    }
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void SetStatus(int id)
        {
            Status = Statuses[id].Name;
        }

        private void LoadBrands()
        {
            Brands = new List<BrandModel>();

            using (var connection = new SqlConnection(DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Brands";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Brands.Add(new BrandModel()
                        {
                            Id = Convert.ToInt32(dr["BrandId"]),
                            Name = dr["Name"].ToString()
                        });
                    }
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadColors()
        {
            Colors = new List<ColorsModel>();

            using (var connection = new SqlConnection(DBConnectionString))
            {
                try
                {
                    const string query = "Select * From Colors";
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Colors.Add(new ColorsModel()
                        {
                            ColorId = Convert.ToInt32(dr["ColorId"]),
                            Name = dr["Name"].ToString()
                        });
                    }
                }
                catch (SqlException ex)
                { }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
