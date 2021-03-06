// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkDeviceOrHostAddressConstKHR
    {
        [FieldOffset(0)]
        [NativeTypeName("VkDeviceAddress")]
        public ulong deviceAddress;

        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* hostAddress;
    }
}
