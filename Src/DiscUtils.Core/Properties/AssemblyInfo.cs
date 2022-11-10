﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

[assembly: AssemblyVersion("0.15.1.0")]
[assembly: AssemblyTitle("DiscUtils")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Kenneth Bell")]
[assembly: AssemblyProduct("DiscUtils")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("64a0f4ef-c057-4afe-a8fb-3152de41b143")]
[assembly: NeutralResourcesLanguage("en")]
[assembly: InternalsVisibleTo("DiscUtils, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.BootConfig, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Btrfs, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Containers, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Dmg, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Ext, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Fat, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.FileSystems, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.HfsPlus, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Iscsi, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Iso9660, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Net, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Nfs, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Ntfs, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.OpticalDiscSharing, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.OpticalDisk, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Registry, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Sdi, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.SquashFs, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Streams, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Swap, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Transports, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Udf, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Vdi, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Vfs, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Vhd, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Vhdx, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Vmdk, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Wim, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Xva, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Diagnostics, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Lvm, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("DiscUtils.Xfs, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: InternalsVisibleTo("LibraryTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001002dd4559c6ce0993d5f997c8a60dc435b43657aaa51875cbeceaaed664a28ef584176a7c34251e78a6e86858f06e580a61d70aace0801b74c7c4d2542491e75b2245611b3be9bccc11175b4a7c803e09c7a857415f511842edc5af7453581e5aa472d98b7c50ae113fab283424acda020d972d361fc15ec0daafa77ecdd6258a9")]
[assembly: AssemblyDescription("Implementation of the ISO, UDF, FAT and NTFS file systems is now fairly stable. VHD, XVA, VMDK and VDI disk formats are implemented, as well as read/write Registry support. The library also includes a simple iSCSI initiator, for accessing disks via iSCSI and an NFS client implementation.")]
[assembly: AssemblyFileVersion("0.15.1.0")]
[assembly: AssemblyInformationalVersion("0.15.1-ci.2+Branch.master.Sha.a55e2e8b79cafbc2b8435d31cfb704244a577f13.a55e2e8b79cafbc2b8435d31cfb704244a577f13")]
