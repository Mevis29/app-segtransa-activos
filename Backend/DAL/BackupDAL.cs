using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackupDAL
    {
        private static Server GetServer()
        {
            ServerConnection conn = new ServerConnection();
            Server myServer = new Server(conn);
            return myServer;
        }

        public static void BackupDataBase(string databaseName, string destinationPath)
        {
            Server myServer = GetServer();
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = databaseName;
            destinationPath = System.IO.Path.Combine(destinationPath, databaseName + ".bak");
            backup.Devices.Add(new BackupDeviceItem(destinationPath, DeviceType.File));
            backup.Initialize = true;
            backup.Checksum = true;
            backup.ContinueAfterError = true;
            backup.Incremental = false;
            backup.LogTruncation = BackupTruncateLogType.Truncate;
            // Perform backup.
            backup.SqlBackup(myServer);
        }
    }
}
