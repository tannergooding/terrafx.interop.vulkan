// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkExternalFenceFeatureFlagBits
    {
        VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = 0x00000001,
        VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = 0x00000002,
        VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT,
        VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT,
        VK_EXTERNAL_FENCE_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
