// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDeviceSynchronization2FeaturesKHR" /> struct.</summary>
    public static unsafe class VkPhysicalDeviceSynchronization2FeaturesKHRTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDeviceSynchronization2FeaturesKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDeviceSynchronization2FeaturesKHR>(), Is.EqualTo(sizeof(VkPhysicalDeviceSynchronization2FeaturesKHR)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceSynchronization2FeaturesKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDeviceSynchronization2FeaturesKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceSynchronization2FeaturesKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDeviceSynchronization2FeaturesKHR), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDeviceSynchronization2FeaturesKHR), Is.EqualTo(12));
            }
        }
    }
}
