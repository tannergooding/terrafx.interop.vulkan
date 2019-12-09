// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_wayland.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkCreateWaylandSurfaceKHR", ExactSpelling = true)]
        public static extern VkResult vkCreateWaylandSurfaceKHR([NativeTypeName("VkInstance")] IntPtr instance, [NativeTypeName("const VkWaylandSurfaceCreateInfoKHR *")] VkWaylandSurfaceCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkSurfaceKHR *")] ulong* pSurface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "vkGetPhysicalDeviceWaylandPresentationSupportKHR", ExactSpelling = true)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint vkGetPhysicalDeviceWaylandPresentationSupportKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("uint32_t")] uint queueFamilyIndex, [NativeTypeName("struct wl_display *")] IntPtr display);
    }
}
