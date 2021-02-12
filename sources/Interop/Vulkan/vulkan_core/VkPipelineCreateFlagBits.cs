// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkPipelineCreateFlagBits
    {
        VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x00000001,
        VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x00000002,
        VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x00000004,
        VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = 0x00000008,
        VK_PIPELINE_CREATE_DISPATCH_BASE_BIT = 0x00000010,
        VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = 0x00004000,
        VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = 0x00008000,
        VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = 0x00010000,
        VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = 0x00020000,
        VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = 0x00001000,
        VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR = 0x00002000,
        VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x00080000,
        VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = 0x00000020,
        VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR = 0x00000040,
        VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = 0x00000080,
        VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV = 0x00040000,
        VK_PIPELINE_CREATE_LIBRARY_BIT_KHR = 0x00000800,
        VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT = 0x00000100,
        VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT = 0x00000200,
        VK_PIPELINE_CREATE_DISPATCH_BASE = VK_PIPELINE_CREATE_DISPATCH_BASE_BIT,
        VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR = VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT,
        VK_PIPELINE_CREATE_DISPATCH_BASE_KHR = VK_PIPELINE_CREATE_DISPATCH_BASE,
        VK_PIPELINE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
