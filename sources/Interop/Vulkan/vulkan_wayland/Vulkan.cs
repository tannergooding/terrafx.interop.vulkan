// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_wayland.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(libraryPath, EntryPoint = "vkCreateWaylandSurfaceKHR", CallingConvention = CallingConvention.Cdecl)]
        public static extern VkResult vkCreateWaylandSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkWaylandSurfaceCreateInfoKHR *")] VkWaylandSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(libraryPath, EntryPoint = "vkGetPhysicalDeviceWaylandPresentationSupportKHR", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceWaylandPresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("struct wl_display *")] IntPtr display);
    }
}