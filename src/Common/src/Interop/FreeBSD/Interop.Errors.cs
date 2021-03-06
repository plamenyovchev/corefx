// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

internal static partial class Interop
{
    /// <summary>Common Unix errno error codes.</summary>
    internal static partial class Errors
    {
        // These values were defined in:
        // include/errno.h

        internal const int EDEADLK = 11;

        internal const int EAGAIN = 35;
        internal const int EWOULDBLOCK = EAGAIN;
        internal const int EINPROGRESS = 36;
        internal const int EALREADY = 37;
        internal const int ENOTSOCK = 38;
        internal const int EDESTADDRREQ = 39;
        internal const int EMSGSIZE = 40;
        internal const int EPROTOTYPE = 41;
        internal const int ENOPROTOOPT = 42;
        internal const int EPROTONOSUPPORT = 43;
        internal const int ESOCKTNOSUPPORT = 44;
        internal const int EOPNOTSUPP = 45;
        internal const int ENOTSUP = EOPNOTSUPP;
        internal const int EPFNOSUPPORT = 46;
        internal const int EAFNOSUPPORT = 47;
        internal const int EADDRINUSE = 48;
        internal const int EADDRNOTAVAIL = 49;
        internal const int ENETDOWN = 50;
        internal const int ENETUNREACH = 51;
        internal const int ENETRESET = 52;
        internal const int ECONNABORTED = 53;
        internal const int ECONNRESET = 54;
        internal const int ENOBUFS = 55;
        internal const int EISCONN = 56;
        internal const int ENOTCONN = 57;
        internal const int ESHUTDOWN = 58;
        internal const int ETOOMANYREFS = 59;
        internal const int ETIMEDOUT = 60;
        internal const int ECONNREFUSED = 61;
        internal const int ELOOP = 62;
        internal const int ENAMETOOLONG = 63;
        internal const int EHOSTDOWN = 64;
        internal const int EHOSTUNREACH = 65;
        internal const int ENOTEMPTY = 66;
        internal const int EPROCLIM = 67;
        internal const int EUSERS = 68;
        internal const int EDQUOT = 69;
        internal const int ESTALE = 70;
        internal const int EREMOTE = 71;
        internal const int EBADRPC = 72;
        internal const int ERPCMISMATCH = 73;
        internal const int EPROGUNAVAIL = 74;
        internal const int EPROGMISMATCH = 75;
        internal const int EPROCUNAVAIL = 76;
        internal const int ENOLCK = 77;
        internal const int ENOSYS = 78;
        internal const int EFTYPE = 79;
        internal const int EAUTH = 80;
        internal const int ENEEDAUTH = 81;
        internal const int EIDRM = 82;
        internal const int ENOMSG = 83;
        internal const int EOVERFLOW = 84;
        internal const int ECANCELED = 85;
        internal const int EILSEQ = 86;
        internal const int ENOATTR = 87;
        internal const int EDOOFUS = 88;
        internal const int EBADMSG = 89;
        internal const int EMULTIHOP = 90;
        internal const int ENOLINK = 91;
        internal const int EPROTO = 92;
        internal const int ENOTCAPABLE = 93;
        internal const int ECAPMODE = 94;
        internal const int ENOTRECOVERABLE = 95;
        internal const int EOWNERDEAD = 96;
        internal const int ELAST = 96;
    }
}
