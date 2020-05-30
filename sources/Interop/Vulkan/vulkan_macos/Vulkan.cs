// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_macos.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", EntryPoint = "vkCreateMacOSSurfaceMVK", ExactSpelling = true)]
        public static extern VkResult vkCreateMacOSSurfaceMVK([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkMacOSSurfaceCreateInfoMVK *")] VkMacOSSurfaceCreateInfoMVK* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);
    }
}
