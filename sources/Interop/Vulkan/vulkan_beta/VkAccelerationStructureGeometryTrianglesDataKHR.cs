// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkFormat vertexFormat;

        public VkDeviceOrHostAddressConstKHR vertexData;

        [NativeTypeName("VkDeviceSize")]
        public ulong vertexStride;

        public VkIndexType indexType;

        public VkDeviceOrHostAddressConstKHR indexData;

        public VkDeviceOrHostAddressConstKHR transformData;
    }
}
