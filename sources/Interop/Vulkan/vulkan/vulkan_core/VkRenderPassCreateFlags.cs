// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum VkRenderPassCreateFlags : uint
    {
        VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = 0x00000002,
        VK_RENDER_PASS_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
