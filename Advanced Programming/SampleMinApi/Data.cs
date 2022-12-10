using Dapper;
using System.Data;
using System.Data.SqlClient;

public class Data
{
    public int Data1 { get; set; }
    public string? Data2 { get; set; }
}

public interface IDataRepo{
    List<Data> GetAll();
    Data Get(int id);
    void AddData(Data data);
    void UpdateData(int no, Data updated);
    void DeleteData(int id);
}


public class DataContext
{
    private readonly IConfiguration _config;
    private readonly string? connStr;
    public DataContext(IConfiguration config)
    {
        _config = config;
        connStr = config.GetConnectionString("MyConnection");
    }

    public IDbConnection GetConnection() => new SqlConnection(connStr);

}

public class DataRepo : IDataRepo
{
    private readonly IConfiguration _config;
    private readonly DataContext context;
    public DataRepo(IConfiguration config, DataContext context)
    {
        _config = config;
        this.context = context;
    }

    public void AddData(Data data)
    {
        var query = "Insert into Data values(@v1, @v2)";
        //var query = _config["Queries:CreateData"]
        using (var con = context.GetConnection()) 
        {
            con.Open();
            con.Execute(query, new { v1 = data.Data1, v2 = data.Data2 });
            con.Close();
        }
    }

    public void DeleteData(int id)
    {
        throw new NotImplementedException();
    }

    public Data Get(int id)
    {
        using (var con = context.GetConnection())
        {
            con.Open();
            var data = con.QuerySingle<Data>("Select * from Data where Data1 = @id", new { id = id});
            con.Close();
            return data;
        }
    }

    public List<Data> GetAll()
    {
        using(var con = context.GetConnection()) 
        {
            con.Open();
            var data = con.Query<Data>("Select * from Data");
            con.Close();
            return data.ToList();
        }
    }

    public void UpdateData(int no, Data updated)
    {
        throw new NotImplementedException();
    }
}