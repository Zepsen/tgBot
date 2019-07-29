// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with BotHandler Builder V4 SDK Template for Visual Studio EmptyBot v4.3.0

using EmptyBot1;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Bot.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
