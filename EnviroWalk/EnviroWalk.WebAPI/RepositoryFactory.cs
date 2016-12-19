using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnviroWalk.Repository.SQLServer;

namespace EnviroWalk.WebAPI
{
    public class RepositoryFactory
    {
        public static T GetRepository<T>()
        {
            object repository = new SQLRepository();
            return (T) repository;
        }

    }
}