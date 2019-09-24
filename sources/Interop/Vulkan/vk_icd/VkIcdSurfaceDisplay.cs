// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_icd.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkIcdSurfaceDisplay
    {
        public VkIcdSurfaceBase @base;

        [NativeTypeName("VkDisplayModeKHR")]
        public ulong displayMode;

        [NativeTypeName("uint32_t")]
        public uint planeIndex;

        [NativeTypeName("uint32_t")]
        public uint planeStackIndex;

        public VkSurfaceTransformFlagBitsKHR transform;

        public float globalAlpha;

        public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;

        public VkExtent2D imageExtent;
    }
}