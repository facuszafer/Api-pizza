using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace PIZZAS.API
{

public static class BD {

    private static string CONNECTION_STRING = @"Persist Security Info=False;User
    ID=Pizzas;password=VivaLaMuzza123;Initial Catalog=DAI-Pizzas;Data Source=.;";

    public static List<Pizza> GetAll() {

        string sqlQuery;

            List<Pizza> returnList;

            returnList = new List<Pizza>();

        using (SqlConnection db = new SqlConnection(CONNECTION_STRING)) {

            sqlQuery = "SELECT Id, Nombre, LibreGluten, Importe, Descripcion FROM Pizzas";

            returnList = db.Query<Pizza>(sqlQuery).ToList();

        }

        return returnList;

    }


public static Pizza GetById(int id) {

        string sqlQuery;

        Pizza returnEntity = null;

        sqlQuery = "SELECT Id, Nombre, LibreGluten, Importe, Descripcion FROM Pizzas ";

        sqlQuery += "WHERE Id = @idPizza";

        using (SqlConnection db = new SqlConnection(CONNECTION_STRING)) {

            returnEntity = db.QueryFirstOrDefault<Pizza>(sqlQuery, new { idPizza = id });

        }

        return returnEntity;

    }



}

