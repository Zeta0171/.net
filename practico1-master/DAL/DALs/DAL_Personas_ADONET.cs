using DAL.IDALs;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace DAL.DALs
{
    public class DAL_Personas_ADONET : IDAL_Personas
    {
        public Persona AddPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public void DeletePersona(long id)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersona(long id)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public Persona UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }
        
        string connectionString = "Server=SantinoLaptop\\SQLEXPRESS;Database=practico1;Integrated Security=True;TrustServerCertificate=True";
        /*
        public void AddPersona(Persona persona)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO persona (Id, Nombre, Documento) VALUES (@Id, @Nombre, @Documento)";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@Id", persona.Id);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Documento", persona.Documento);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
            
        }

        public void DeletePersona(long id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM persona WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@Id", id);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Persona GetPersona(long id)
        {
            Persona persona = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre, Documento FROM persona WHERE id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Documento",Documento);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        persona = new Persona
                        {
                            Id = (long)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Documento = reader["Documento"].ToString()
                        };
                    }
                }
            }

            return persona;
        }

        public List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre, Documento FROM persona";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Persona persona = new Persona
                        {
                            Id = (long)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Documento = reader["Documento"].ToString(),
                        };

                        personas.Add(persona);
                    }
                }
            }

            return personas;
        }

        public void UpdatePersona(Persona persona)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE persona SET Nombre = @Nombre WHERE Documento = @Documento";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Documento", persona.Documento);
                //command.Parameters.AddWithValue("@Id", persona.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        */
    }
}
