// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void PFN_vkCmdBeginQuery([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("VkQueryPool")] ulong queryPool, [NativeTypeName("uint32_t")] uint query, [NativeTypeName("VkQueryControlFlags")] uint flags);
}
