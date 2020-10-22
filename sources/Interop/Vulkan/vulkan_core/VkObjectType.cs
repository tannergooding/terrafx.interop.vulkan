// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public enum VkObjectType
    {
        VK_OBJECT_TYPE_UNKNOWN = 0,
        VK_OBJECT_TYPE_INSTANCE = 1,
        VK_OBJECT_TYPE_PHYSICAL_DEVICE = 2,
        VK_OBJECT_TYPE_DEVICE = 3,
        VK_OBJECT_TYPE_QUEUE = 4,
        VK_OBJECT_TYPE_SEMAPHORE = 5,
        VK_OBJECT_TYPE_COMMAND_BUFFER = 6,
        VK_OBJECT_TYPE_FENCE = 7,
        VK_OBJECT_TYPE_DEVICE_MEMORY = 8,
        VK_OBJECT_TYPE_BUFFER = 9,
        VK_OBJECT_TYPE_IMAGE = 10,
        VK_OBJECT_TYPE_EVENT = 11,
        VK_OBJECT_TYPE_QUERY_POOL = 12,
        VK_OBJECT_TYPE_BUFFER_VIEW = 13,
        VK_OBJECT_TYPE_IMAGE_VIEW = 14,
        VK_OBJECT_TYPE_SHADER_MODULE = 15,
        VK_OBJECT_TYPE_PIPELINE_CACHE = 16,
        VK_OBJECT_TYPE_PIPELINE_LAYOUT = 17,
        VK_OBJECT_TYPE_RENDER_PASS = 18,
        VK_OBJECT_TYPE_PIPELINE = 19,
        VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = 20,
        VK_OBJECT_TYPE_SAMPLER = 21,
        VK_OBJECT_TYPE_DESCRIPTOR_POOL = 22,
        VK_OBJECT_TYPE_DESCRIPTOR_SET = 23,
        VK_OBJECT_TYPE_FRAMEBUFFER = 24,
        VK_OBJECT_TYPE_COMMAND_POOL = 25,
        VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION = 1000156000,
        VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE = 1000085000,
        VK_OBJECT_TYPE_SURFACE_KHR = 1000000000,
        VK_OBJECT_TYPE_SWAPCHAIN_KHR = 1000001000,
        VK_OBJECT_TYPE_DISPLAY_KHR = 1000002000,
        VK_OBJECT_TYPE_DISPLAY_MODE_KHR = 1000002001,
        VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = 1000011000,
        VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = 1000128000,
        VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR = 1000165000,
        VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = 1000160000,
        VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL = 1000210000,
        VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR = 1000268000,
        VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV = 1000277000,
        VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT = 1000295000,
        VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR = VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE,
        VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR = VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION,
        VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR,
        VK_OBJECT_TYPE_MAX_ENUM = 0x7FFFFFFF,
    }
}
