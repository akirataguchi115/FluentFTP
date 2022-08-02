﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace FluentFTP.Xunit.Docker.Containers {
	internal class PyFtpdLibContainer : DockerFtpContainer {
		public PyFtpdLibContainer() {
			Type = FtpServer.PyFtpdLib;
			ServerType = "pyftpdlib";
			DockerImage = "akogut/docker-pyftpdlib";
			DockerGithub = "https://github.com/andriykohut/docker-pyftpdlib";
			//RunCommand = "docker run -it --rm -p 21:21 pyftpdlib:fluentftp";
			FixedUsername = "user";
			FixedPassword = "password";
		}

		/// <summary>
		/// For help creating this section see https://github.com/testcontainers/testcontainers-dotnet#supported-commands
		/// </summary>
		public override void Configure(ITestcontainersBuilder<TestcontainersContainer> builder) {
		}
	}
}