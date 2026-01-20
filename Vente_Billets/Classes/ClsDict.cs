using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace Vente_Billets.Classes
{
    class ClsDict
    {
        static ClsDict instance = null;

        public static ClsDict Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClsDict();
                return instance;
            }
        }

        SqlConnection con = null;
        SqlCommand cmd = null;
        private SqlDataAdapter dt;
        private SqlDataReader dr;

        public bool OpenConnection()
        {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection(ClsConnexion.waybd);
                }

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
                return false;
            }
        }

        public void SaveUpdateClients(ClsClients cli)
        {
            string query = @"EXEC sp_SaveOrUpdateClient_Flexible @id, @noms, @adresse, @contact, @genre, @age";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", cli.Id);
                cmd.Parameters.AddWithValue("@noms", cli.Noms);
                cmd.Parameters.AddWithValue("@adresse", cli.Adresse);
                cmd.Parameters.AddWithValue("@contact", cli.Contact);
                cmd.Parameters.AddWithValue("@genre", cli.Genre);
                cmd.Parameters.AddWithValue("@age", cli.Age);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateAgents(ClsAgents Ag)
        {
            string query = @"EXEC sp_SaveOrUpdateAgent_Flexible @id, @noms, @contact, @fonction, @username, @pwd, @refSalle";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", Ag.Id);
                cmd.Parameters.AddWithValue("@noms", Ag.Noms);
                cmd.Parameters.AddWithValue("@fonction", Ag.Fonction);
                cmd.Parameters.AddWithValue("@contact", Ag.Contact);
                cmd.Parameters.AddWithValue("@username", Ag.Username);
                cmd.Parameters.AddWithValue("@pwd", Ag.Password);
                cmd.Parameters.AddWithValue("@refSalle", Ag.RefSalle);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateSalle(ClsSalle sa)
        {
            string query = @"EXEC SaveOrUpdateSalle @id, @nomSalle, @adresse, @nombrePlace";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", sa.Id);
                cmd.Parameters.AddWithValue("@nomSalle", sa.NomSalle);
                cmd.Parameters.AddWithValue("@adresse", sa.Adesse);
                cmd.Parameters.AddWithValue("@nombrePlace", sa.NombrePlace);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateSpectacle(ClsSpectacle spect)
        {
            string query = @"EXEC SaveOrUpdateSpectacle @id, @titre, @dateSpectacle, @nombreBillet, @duree, @descriptionSpectacle, @refSalle";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", spect.Id);
                cmd.Parameters.AddWithValue("@titre", spect.Titre);
                cmd.Parameters.AddWithValue("@dateSpectacle", spect.DateSpectacle);
                cmd.Parameters.AddWithValue("@nombreBillet", spect.NombreBillet);
                cmd.Parameters.AddWithValue("@duree", spect.Duree);
                cmd.Parameters.AddWithValue("@descriptionSpectacle", spect.DescSpect);
                cmd.Parameters.AddWithValue("@refSalle", spect.RefSalle);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdatePlace(ClsPlace pl)
        {
            string query = @"EXEC SaveOrUpdatePlace @id, @numero, @refSalle, @refCategorie";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", pl.Id);
                cmd.Parameters.AddWithValue("@refCategorie", pl.RefCategorie);
                cmd.Parameters.AddWithValue("@numero", pl.NumPlace);
                cmd.Parameters.AddWithValue("@refSalle", pl.RefSalle);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdatePaiement(ClsPaiement paie)
        {
            string query = @"EXEC SaveOrUpdatePaiement @id, @datePaiement, @modePaiement, @montant, @refAgent, @refClient";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", paie.Id);
                cmd.Parameters.AddWithValue("@datePaiement", paie.DatePaiement);
                cmd.Parameters.AddWithValue("@modePaiement", paie.ModePaiement);
                cmd.Parameters.AddWithValue("@montant", paie.Montant);
                cmd.Parameters.AddWithValue("@refAgent", paie.RefAgent);
                cmd.Parameters.AddWithValue("@refClient", paie.RefClient);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdateBillet(ClsBillets bi)
        {
            string query = @"EXEC SaveOrUpdateBillet @id, @prix, @dateAchat, @statut, @refSpectacle, @refClient, @refAgent, @refFacture, @refPlace, @refCat";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", bi.Id);
                cmd.Parameters.AddWithValue("@prix", bi.Prix);
                cmd.Parameters.AddWithValue("@dateAchat", bi.DateAchat);
                cmd.Parameters.AddWithValue("@statut", bi.Statut);
                cmd.Parameters.AddWithValue("@refSpectacle", bi.RefSpectacle1);
                cmd.Parameters.AddWithValue("@refPlace", bi.RefPlace1);
                cmd.Parameters.AddWithValue("@refAgent", bi.RefAgent1);
                cmd.Parameters.AddWithValue("@refClient", bi.RefClient1);
                cmd.Parameters.AddWithValue("@refFacture", bi.RefFacture);
                cmd.Parameters.AddWithValue("@refCat", bi.RefCat1);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveUpdatefacture(ClsFacture fact)
        {
            string query = @"EXEC SaveOrUpdateFacture @id, @refClient, @refAgent, @refPlace";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", fact.Id);
                cmd.Parameters.AddWithValue("@refPlace", fact.RefPlace);
                cmd.Parameters.AddWithValue("@refAgent", fact.RefAgent);
                cmd.Parameters.AddWithValue("@refClient", fact.RefClient);
                cmd.ExecuteNonQuery();
            }
        }

        public void Produire_Facture(int id)
        {
            string query = @"EXEC Production_Facture @id";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Affichez_Facture(int id)
        {
            string query = @"SELECT * FROM Affichez_Facture WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable Imprimez_Recu(string nom)
        {
            string query = @"SELECT * FROM Produire_Recu WHERE noms = @noms";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@noms", nom);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable Imprimez_Billet(int id)
        {
            string query = @"SELECT * FROM Imprmez_Billet WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void SetStatut(int id)
        {
            string query = @"UPDATE tBillet SET statut = 1 WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public bool GetStatut(int id)
        {
            string query = @"SELECT statut FROM tBillet WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (ClsDict.Instance.con.State != ConnectionState.Open)
                    ClsDict.Instance.con.Open();

                cmd.Parameters.AddWithValue("@id", id);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToBoolean(result); // true = vendu, false = non vendu
                }
                else
                {
                    // Si aucun billet trouvé, on considère "non vendu"
                    return false;
                }
            }
        }

        public string GetRole(string username, string pwd)
        {
            string query = @"SELECT fonction FROM tAgents WHERE username = @username AND pwd = @pwd";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (ClsDict.Instance.con.State != ConnectionState.Open)
                    ClsDict.Instance.con.Open();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToString(result); // true = vendu, false = non vendu
                }
                else
                {
                    // Si aucun billet trouvé, on considère "non vendu"
                    return "Agent non trouve";
                }
            }
        }

        public DataTable loadData(string nomTable)
        {
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select * from " + nomTable + "", con);
            dt.Fill(table);
            con.Close();
            return table;
        }

        public void Deletedata(string nomTable, string champ_id, int id)
        {
            string query = $"DELETE FROM {nomTable} where {champ_id} = @id ";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }

        public void loadCombo(string nomTable, string nomchamp, System.Windows.Forms.ComboBox comb1)
        {
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("SELECT " + nomchamp + " FROM " + nomTable + "", con);
            try
            {
                DataTable dt1 = new DataTable();
                dt.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    comb1.Items.Add(dr[nomchamp]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }

            con.Close();
        }

        public string getcode_Combo(string nomTable, string nomChampId, string nomChamp, string valeur)
        {
            string IdData = "";
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select " + nomChampId + " from " + nomTable + " where " + nomChamp + "=@a", con);
                cmd.Parameters.AddWithValue("@a", valeur);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdData = (dr[nomChampId].ToString());
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return IdData;
        }

        public string GetNomDepuisId(string nomTable, string nomChampId, string nomChampAffiche, string valeurId)
        {
            string nomAffiche = "";
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                cmd = new SqlCommand("SELECT " + nomChampAffiche + " FROM " + nomTable + " WHERE " + nomChampId + " = @id", con);
                cmd.Parameters.AddWithValue("@id", valeurId);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomAffiche = dr[nomChampAffiche].ToString();
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            return nomAffiche;
        }

        public DataTable Rechercher(string texte, string nomTable, string Champ)
        {
            if (con.State != ConnectionState.Open) con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM {nomTable} WHERE {Champ} LIKE @val", ClsDict.Instance.con);
            cmd.Parameters.AddWithValue("@val", "%" + texte + "%");

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            ClsDict.Instance.con.Close();
            return table;
        }

        public ClsAgents SeConnecter(string login, string motDePasse)
        {

            if (con.State != ConnectionState.Open) con.Open();
            string query = "SELECT * FROM tAgents WHERE username = @username AND pwd = @mdp";

            using (SqlCommand cmd = new SqlCommand(query, ClsDict.Instance.con))
            {
                cmd.Parameters.AddWithValue("@username", login);
                cmd.Parameters.AddWithValue("@mdp", (motDePasse));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var ag = new ClsAgents
                        {
                            Id = (int)reader["id"],
                            Noms = reader["noms"].ToString(),
                            Contact = reader["contact"].ToString(),
                            Fonction = reader["fonction"].ToString(),
                            Username = reader["username"].ToString(),
                            Password = reader["pwd"].ToString(),
                            RefSalle = reader["refSalle"].ToString(),
                            
                        };

                        return ag;
                    }
                    reader.Close(); // Ferme le lecteur de données après utilisation
                }
            }
            return null; // Si aucune correspondance n'est trouvée

        }

        public static string HasherMotDePasse(string motDePasse)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(motDePasse);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash); // Encodage en Base64 pour stocker dans la BDD
            }
        }

    }
}
