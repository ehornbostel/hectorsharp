﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HectorSharp.Service;

namespace HectorSharp.Dao
{
    /**
     * Provides an abstraction for running an operation, or a command on a cassandra keyspace.
     * Clients of Hector implement the {@link #execute(Keyspace)} and then call
     * {@link #execute(String, int, String)} on an instance of this implementation.
     *
     * The class provides the comfort of managing connections by borowing and then releasing them.
     *
     * @param <OUTPUT> the return type of the command sent to cassandra. If this is just a mutator,
     * such as delete or insert, use Void. Other operations that query actual values from cassandra
     * may use String, List<String> etc, according to their business logic.
     *
     * @author Matt Van Veenendaal (m@mattvv.com)
     * @author Ran Tavory (rantav@gmail.com) (Original Java Version)
     */
    public abstract class Command<OUTPUT>
    {

        /**
         * Implement this abstract method to operate on cassandra.
         *
         * the given keyspace is the keyspace referenced by {@link #execute(String, int, String)}.
         * The method {@link #execute(String, int, String)} calls this method internally and provides it
         * with the keyspace reference.
         *
         * @param ks
         * @return
         * @throws Exception
         */
        public abstract OUTPUT execute(Keyspace ks);

        /**
         * Call this method to run the code within the {@link #execute(Keyspace)} method.
         *
         * @param host
         * @param port
         * @param keyspace
         * @return
         * @throws Exception
         */
        public sealed OUTPUT execute(String host, int port, String keyspace)
        {
            Keyspace ks = getPool().borrowClient(host, port).getKeyspace(keyspace);
            try
            {
                return execute(ks);
            }
            finally
            {
                getPool().releaseClient(ks.getClient());
            }
        }

        protected CassandraClientPool getPool()
        {
            return CassandraClientPoolFactory.INSTANCE.get();
        }
    }
}
