// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkSamplerCreateFlagBits
    {
        VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = 0x00000001,
        VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = 0x00000002,
        VK_SAMPLER_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
