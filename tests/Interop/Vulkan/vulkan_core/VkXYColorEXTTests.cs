// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkXYColorEXT" /> struct.</summary>
    public static unsafe class VkXYColorEXTTests
    {
        /// <summary>Validates that the <see cref="VkXYColorEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkXYColorEXT>(), Is.EqualTo(sizeof(VkXYColorEXT)));
        }

        /// <summary>Validates that the <see cref="VkXYColorEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkXYColorEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkXYColorEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkXYColorEXT), Is.EqualTo(8));
        }
    }
}
