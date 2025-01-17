﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.WebJobs.Extensions.SignalRService
{
    internal interface IServiceManagerStore
    {
        IInternalServiceHubContextStore GetOrAddByConnectionStringKey(string connectionStringKey);
    }
}