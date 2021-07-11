// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties imageFormatProperties;

        public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;

        public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;

        public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }
}