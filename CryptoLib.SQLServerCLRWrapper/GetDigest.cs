﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString GetDigest(string DigestThisString, string UseThisSalt)
    {
        // Put your code here
        return new SqlString("Hello");
    }
};

