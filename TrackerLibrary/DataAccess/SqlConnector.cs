using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using System.Data.SqlClient;
using System.Data;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel person)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                using (SqlCommand command = new SqlCommand("dbo.spPeople_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = person.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = person.LastName;
                    command.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = person.EmailAddress;
                    command.Parameters.Add("@CellPhoneNumber", SqlDbType.VarChar).Value = person.CellPhoneNumber;

                    SqlParameter idParameter = new SqlParameter("@id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(idParameter);
                    connection.Open();
                    command.ExecuteNonQuery();

                    person.Id = Convert.ToInt32(idParameter.Value);
                }
            }
            return person;
        }

        public TeamModel CreateTeam(TeamModel team)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                using (SqlCommand command = new SqlCommand("dbo.spTeams_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@TeamName", SqlDbType.NVarChar).Value = team.TeamName;

                    SqlParameter idParameter = new SqlParameter("@id", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(idParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    team.Id = Convert.ToInt32(idParameter.Value);

                    using (SqlCommand command2 = new SqlCommand("dbo.spTeamMembers_Insert", connection))
                    {
                        command2.CommandType = CommandType.StoredProcedure;

                        foreach (PersonModel person in team.TeamMembers)
                        {
                            command2.Parameters.Clear();

                            command2.Parameters.Add("@TeamId", SqlDbType.Int).Value = team.Id;
                            command2.Parameters.Add("@PersonId", SqlDbType.Int).Value = person.Id;

                            command2.ExecuteNonQuery();
                        }
                    }

                    connection.Close();
                    return team;
                }
            }
        }

        public List<TeamModel> GetTeams()
        {
            List<TeamModel> teams = new List<TeamModel>();

            // First, get all teams
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                using (SqlCommand command = new SqlCommand("dbo.spTeam_GetAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        teams.Add(new TeamModel()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            TeamName = reader["TeamName"].ToString()
                        });
                    }
                }
            }

            // For each team, get its members
            foreach (TeamModel team in teams)
            {
                using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
                {
                    using (SqlCommand command = new SqlCommand("dbo.spTeamMembers_GetByTeam", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeamId", team.Id);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        List<PersonModel> teamMembers = new List<PersonModel>();
                        while (reader.Read())
                        {
                            PersonModel person = new PersonModel
                            {
                                Id = (int)reader["Id"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                EmailAddress = reader["EmailAddress"].ToString(),
                                CellPhoneNumber = reader["CellPhoneNumber"].ToString()
                            };
                            teamMembers.Add(person);
                        }
                        team.TeamMembers = teamMembers;
                    }
                }
            }

            return teams;
        }

        public List<PersonModel> GetPersons()
        {
            List<PersonModel> persons = new List<PersonModel>();
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                using (SqlCommand command = new SqlCommand("dbo.spPeople_GetAll", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        persons.Add(new PersonModel()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            EmailAddress = reader["EmailAddress"].ToString(),
                            CellPhoneNumber = reader["CellPhoneNumber"].ToString()
                        });
                    }
                }
            }
            return persons;
        }

        ///TODO - Make the create prize method acctually to save the db
        /// <summary>
        /// Save a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize informations, including Unique identifiers</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                using (SqlCommand command = new SqlCommand("dbo.spPrizes_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PlaceNumber", SqlDbType.Int).Value = model.PlaceNumber;
                    command.Parameters.Add("@PlaceName", SqlDbType.NVarChar).Value = model.PlaceName;
                    command.Parameters.Add("@PrizeAmount", SqlDbType.Money).Value = model.PrizeAmount;
                    command.Parameters.Add("@PrizePercentage", SqlDbType.Float).Value = model.PrizePercentage;

                    SqlParameter idParameter = new SqlParameter("@id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(idParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    model.Id = Convert.ToInt32(idParameter.Value);
                }
            }
            return model;
        }


    }
}
