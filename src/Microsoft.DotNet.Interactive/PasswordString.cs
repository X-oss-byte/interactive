﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive;

public class PasswordString
{
    private readonly string _clearTextPassword;

    public PasswordString(string clearTextPassword)
    {
        _clearTextPassword = clearTextPassword;
    }

    public string GetClearTextPassword() => _clearTextPassword;
}