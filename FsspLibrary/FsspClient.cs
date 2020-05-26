using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace FsspLibrary
{
    public class FsspClient
    {
        private WebClient client { get; set; }
        private string token { get; set; }
        private string apiUrl { get; set; }

        public FsspClient(string tokenkey)
        {
            client = new WebClient();
            token = $"?token={tokenkey}&";
            apiUrl = "https://api-ip.fssprus.ru/api/v1.0/";
        }

        public Result[] GetInfoPhysical(PhysicalPerson person)
        {
            string comStr = "search/physical" + token + person.ToString();
            var task = GetTaskCommand(comStr);
            var status = GetTaskState(task.response.task);
            while (status != 0)
            {
                Thread.Sleep(2000);
                status = GetTaskState(task.response.task);
            }
            var result = GetResult(task.response.task);
            return result;
        }

        private ResponseFssp GetTaskCommand(string cmd)
        {

            var request = client.DownloadData(apiUrl + cmd);

            var result = JsonConvert.DeserializeObject<ResponseFssp>(Encoding.UTF8.GetString(request));

            return result;
        }

        private int GetTaskState(string task)
        {
            string comStr = $"status{token}task={task}";
            return GetTaskCommand(comStr).response.status;
        }

        private Result[] GetResult(string task)
        {
            string comStr = $"result{token}task={task}";
            var result = GetTaskCommand(comStr);
            return result.response.result;
        }

    }
}
