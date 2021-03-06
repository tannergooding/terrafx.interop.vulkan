// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkValidationFeatureDisableEXT
    {
        VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = 0,
        VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = 1,
        VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = 2,
        VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = 3,
        VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = 4,
        VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = 5,
        VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = 6,
        VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT = 7,
        VK_VALIDATION_FEATURE_DISABLE_MAX_ENUM_EXT = 0x7FFFFFFF,
    }
}
