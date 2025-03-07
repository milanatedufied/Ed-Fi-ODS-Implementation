﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Autofac;
using EdFi.Admin.DataAccess.Utils;
using EdFi.Ods.Api.ExternalTasks;

namespace EdFi.Ods.Api.IntegrationTestHarness.Modules
{
    public class UpdateAdminDatabaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UpdateAdminDatabaseTask>()
                .As<IExternalTask>();

            builder.RegisterType<UpdateSecurityDatabaseTask>()
                .As<IExternalTask>();

            builder.RegisterType<DefaultApplicationCreator>()
                .As<IDefaultApplicationCreator>();
        }
    }
}
