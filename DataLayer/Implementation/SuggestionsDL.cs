using ApplicationObjects.BO;
using DataLayer.Interfaces;
using System;
using System.Configuration;
using System.Data.OleDb;

namespace DataLayer.Implementation
{
    public class SuggestionsDL : ISuggestions
    {
        public string SaveSuggestions(SuggestionsBO suggestion)
        {
            string QueryText = "INSERT INTO SuggestionsTemp (Usefullness,Satisfaction,EaseOfUse,LookAndFeel,Feedback, IP, SuggestedDate) values (@Usefullness,@Satisfaction,@EaseOfUse,@LookAndFeel,@Feedback,@IP,@SuggestedDate)";
            using (OleDbConnection connect = new OleDbConnection(ConfigurationManager.AppSettings["OLEDBConnectionString"].ToString()))
            using (OleDbCommand command = new OleDbCommand(QueryText, connect))
            {
                try
                {
                    connect.Open();

                    command.Parameters.AddWithValue("@Usefullness", suggestion.Usefullness);
                    command.Parameters.AddWithValue("@Satisfaction", suggestion.Satisfaction);
                    command.Parameters.AddWithValue("@EaseOfUse", suggestion.EaseOfUse);
                    command.Parameters.AddWithValue("@LookAndFeel", suggestion.LookAndFeel);
                    command.Parameters.AddWithValue("@Feedback", string.IsNullOrEmpty(suggestion.Feedback)? string.Empty:suggestion.Feedback);
                    command.Parameters.AddWithValue("@IP", string.IsNullOrEmpty(suggestion.IP) ? string.Empty : suggestion.IP);
                    command.Parameters.AddWithValue("@SuggestedDate", DateTime.Now.ToString());

                    command.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    Utilities.Logger.Log(ex.Message);
                    return ex.Message;
                }
                finally
                {
                    connect.Close();
                }
                return true.ToString();
            }
        }
    }
}
