// This file was generated, don't manually edit
namespace Vulkan_1_3;

public unsafe struct VkExtent2D
{
	public uint32_t width;
	public uint32_t height;
}
public unsafe struct VkExtent3D
{
	public uint32_t width;
	public uint32_t height;
	public uint32_t depth;
}
public unsafe struct VkOffset2D
{
	public int32_t x;
	public int32_t y;
}
public unsafe struct VkOffset3D
{
	public int32_t x;
	public int32_t y;
	public int32_t z;
}
public unsafe struct VkRect2D
{
	public VkOffset2D offset;
	public VkExtent2D extent;
}
public unsafe struct VkBaseInStructure
{
	public VkStructureType sType;
	public VkBaseInStructure* pNext;
}
public unsafe struct VkBaseOutStructure
{
	public VkStructureType sType;
	public VkBaseOutStructure* pNext;
}
public unsafe struct VkBufferMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
public unsafe struct VkDispatchIndirectCommand
{
	public uint32_t x;
	public uint32_t y;
	public uint32_t z;
}
public unsafe struct VkDrawIndexedIndirectCommand
{
	public uint32_t indexCount;
	public uint32_t instanceCount;
	public uint32_t firstIndex;
	public int32_t vertexOffset;
	public uint32_t firstInstance;
}
public unsafe struct VkDrawIndirectCommand
{
	public uint32_t vertexCount;
	public uint32_t instanceCount;
	public uint32_t firstVertex;
	public uint32_t firstInstance;
}
public unsafe struct VkImageMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}
public unsafe struct VkImageSubresourceRange
{
	public VkImageAspectFlags aspectMask;
	public uint32_t baseMipLevel;
	public uint32_t levelCount;
	public uint32_t baseArrayLayer;
	public uint32_t layerCount;
}
public unsafe struct VkMemoryBarrier
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
}
public unsafe struct VkPipelineCacheHeaderVersionOne
{
	public uint32_t headerSize;
	public VkPipelineCacheHeaderVersion headerVersion;
	public uint32_t vendorID;
	public uint32_t deviceID;
	public uint8_t pipelineCacheUUID_0;
	public uint8_t pipelineCacheUUID_1;
	public uint8_t pipelineCacheUUID_2;
	public uint8_t pipelineCacheUUID_3;
	public uint8_t pipelineCacheUUID_4;
	public uint8_t pipelineCacheUUID_5;
	public uint8_t pipelineCacheUUID_6;
	public uint8_t pipelineCacheUUID_7;
	public uint8_t pipelineCacheUUID_8;
	public uint8_t pipelineCacheUUID_9;
	public uint8_t pipelineCacheUUID_10;
	public uint8_t pipelineCacheUUID_11;
	public uint8_t pipelineCacheUUID_12;
	public uint8_t pipelineCacheUUID_13;
	public uint8_t pipelineCacheUUID_14;
	public uint8_t pipelineCacheUUID_15;
}
public unsafe struct VkInstanceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkInstanceCreateFlags flags;
	public VkApplicationInfo* pApplicationInfo;
	public uint32_t enabledLayerCount;
	public char** ppEnabledLayerNames;
	public uint32_t enabledExtensionCount;
	public char** ppEnabledExtensionNames;
}
public unsafe struct VkApplicationInfo
{
	public VkStructureType sType;
	public void* pNext;
	public char* pApplicationName;
	public uint32_t applicationVersion;
	public char* pEngineName;
	public uint32_t engineVersion;
	public uint32_t apiVersion;
}
public unsafe struct VkAllocationCallbacks
{
	public void* pUserData;
	public PFN_vkAllocationFunction pfnAllocation;
	public PFN_vkReallocationFunction pfnReallocation;
	public PFN_vkFreeFunction pfnFree;
	public PFN_vkInternalAllocationNotification pfnInternalAllocation;
	public PFN_vkInternalFreeNotification pfnInternalFree;
}
public unsafe struct VkPhysicalDeviceFeatures
{
	public VkBool32 robustBufferAccess;
	public VkBool32 fullDrawIndexUint32;
	public VkBool32 imageCubeArray;
	public VkBool32 independentBlend;
	public VkBool32 geometryShader;
	public VkBool32 tessellationShader;
	public VkBool32 sampleRateShading;
	public VkBool32 dualSrcBlend;
	public VkBool32 logicOp;
	public VkBool32 multiDrawIndirect;
	public VkBool32 drawIndirectFirstInstance;
	public VkBool32 depthClamp;
	public VkBool32 depthBiasClamp;
	public VkBool32 fillModeNonSolid;
	public VkBool32 depthBounds;
	public VkBool32 wideLines;
	public VkBool32 largePoints;
	public VkBool32 alphaToOne;
	public VkBool32 multiViewport;
	public VkBool32 samplerAnisotropy;
	public VkBool32 textureCompressionETC2;
	public VkBool32 textureCompressionASTC_LDR;
	public VkBool32 textureCompressionBC;
	public VkBool32 occlusionQueryPrecise;
	public VkBool32 pipelineStatisticsQuery;
	public VkBool32 vertexPipelineStoresAndAtomics;
	public VkBool32 fragmentStoresAndAtomics;
	public VkBool32 shaderTessellationAndGeometryPointSize;
	public VkBool32 shaderImageGatherExtended;
	public VkBool32 shaderStorageImageExtendedFormats;
	public VkBool32 shaderStorageImageMultisample;
	public VkBool32 shaderStorageImageReadWithoutFormat;
	public VkBool32 shaderStorageImageWriteWithoutFormat;
	public VkBool32 shaderUniformBufferArrayDynamicIndexing;
	public VkBool32 shaderSampledImageArrayDynamicIndexing;
	public VkBool32 shaderStorageBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageImageArrayDynamicIndexing;
	public VkBool32 shaderClipDistance;
	public VkBool32 shaderCullDistance;
	public VkBool32 shaderFloat64;
	public VkBool32 shaderInt64;
	public VkBool32 shaderInt16;
	public VkBool32 shaderResourceResidency;
	public VkBool32 shaderResourceMinLod;
	public VkBool32 sparseBinding;
	public VkBool32 sparseResidencyBuffer;
	public VkBool32 sparseResidencyImage2D;
	public VkBool32 sparseResidencyImage3D;
	public VkBool32 sparseResidency2Samples;
	public VkBool32 sparseResidency4Samples;
	public VkBool32 sparseResidency8Samples;
	public VkBool32 sparseResidency16Samples;
	public VkBool32 sparseResidencyAliased;
	public VkBool32 variableMultisampleRate;
	public VkBool32 inheritedQueries;
}
public unsafe struct VkFormatProperties
{
	public VkFormatFeatureFlags linearTilingFeatures;
	public VkFormatFeatureFlags optimalTilingFeatures;
	public VkFormatFeatureFlags bufferFeatures;
}
public unsafe struct VkImageFormatProperties
{
	public VkExtent3D maxExtent;
	public uint32_t maxMipLevels;
	public uint32_t maxArrayLayers;
	public VkSampleCountFlags sampleCounts;
	public VkDeviceSize maxResourceSize;
}
public unsafe struct VkPhysicalDeviceProperties
{
	public uint32_t apiVersion;
	public uint32_t driverVersion;
	public uint32_t vendorID;
	public uint32_t deviceID;
	public VkPhysicalDeviceType deviceType;
	public fixed char deviceName[VK.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
	public uint8_t pipelineCacheUUID_0;
	public uint8_t pipelineCacheUUID_1;
	public uint8_t pipelineCacheUUID_2;
	public uint8_t pipelineCacheUUID_3;
	public uint8_t pipelineCacheUUID_4;
	public uint8_t pipelineCacheUUID_5;
	public uint8_t pipelineCacheUUID_6;
	public uint8_t pipelineCacheUUID_7;
	public uint8_t pipelineCacheUUID_8;
	public uint8_t pipelineCacheUUID_9;
	public uint8_t pipelineCacheUUID_10;
	public uint8_t pipelineCacheUUID_11;
	public uint8_t pipelineCacheUUID_12;
	public uint8_t pipelineCacheUUID_13;
	public uint8_t pipelineCacheUUID_14;
	public uint8_t pipelineCacheUUID_15;
	public VkPhysicalDeviceLimits limits;
	public VkPhysicalDeviceSparseProperties sparseProperties;
}
public unsafe struct VkPhysicalDeviceLimits
{
	public uint32_t maxImageDimension1D;
	public uint32_t maxImageDimension2D;
	public uint32_t maxImageDimension3D;
	public uint32_t maxImageDimensionCube;
	public uint32_t maxImageArrayLayers;
	public uint32_t maxTexelBufferElements;
	public uint32_t maxUniformBufferRange;
	public uint32_t maxStorageBufferRange;
	public uint32_t maxPushConstantsSize;
	public uint32_t maxMemoryAllocationCount;
	public uint32_t maxSamplerAllocationCount;
	public VkDeviceSize bufferImageGranularity;
	public VkDeviceSize sparseAddressSpaceSize;
	public uint32_t maxBoundDescriptorSets;
	public uint32_t maxPerStageDescriptorSamplers;
	public uint32_t maxPerStageDescriptorUniformBuffers;
	public uint32_t maxPerStageDescriptorStorageBuffers;
	public uint32_t maxPerStageDescriptorSampledImages;
	public uint32_t maxPerStageDescriptorStorageImages;
	public uint32_t maxPerStageDescriptorInputAttachments;
	public uint32_t maxPerStageResources;
	public uint32_t maxDescriptorSetSamplers;
	public uint32_t maxDescriptorSetUniformBuffers;
	public uint32_t maxDescriptorSetUniformBuffersDynamic;
	public uint32_t maxDescriptorSetStorageBuffers;
	public uint32_t maxDescriptorSetStorageBuffersDynamic;
	public uint32_t maxDescriptorSetSampledImages;
	public uint32_t maxDescriptorSetStorageImages;
	public uint32_t maxDescriptorSetInputAttachments;
	public uint32_t maxVertexInputAttributes;
	public uint32_t maxVertexInputBindings;
	public uint32_t maxVertexInputAttributeOffset;
	public uint32_t maxVertexInputBindingStride;
	public uint32_t maxVertexOutputComponents;
	public uint32_t maxTessellationGenerationLevel;
	public uint32_t maxTessellationPatchSize;
	public uint32_t maxTessellationControlPerVertexInputComponents;
	public uint32_t maxTessellationControlPerVertexOutputComponents;
	public uint32_t maxTessellationControlPerPatchOutputComponents;
	public uint32_t maxTessellationControlTotalOutputComponents;
	public uint32_t maxTessellationEvaluationInputComponents;
	public uint32_t maxTessellationEvaluationOutputComponents;
	public uint32_t maxGeometryShaderInvocations;
	public uint32_t maxGeometryInputComponents;
	public uint32_t maxGeometryOutputComponents;
	public uint32_t maxGeometryOutputVertices;
	public uint32_t maxGeometryTotalOutputComponents;
	public uint32_t maxFragmentInputComponents;
	public uint32_t maxFragmentOutputAttachments;
	public uint32_t maxFragmentDualSrcAttachments;
	public uint32_t maxFragmentCombinedOutputResources;
	public uint32_t maxComputeSharedMemorySize;
	public uint32_t maxComputeWorkGroupCount_0;
	public uint32_t maxComputeWorkGroupCount_1;
	public uint32_t maxComputeWorkGroupCount_2;
	public uint32_t maxComputeWorkGroupInvocations;
	public uint32_t maxComputeWorkGroupSize_0;
	public uint32_t maxComputeWorkGroupSize_1;
	public uint32_t maxComputeWorkGroupSize_2;
	public uint32_t subPixelPrecisionBits;
	public uint32_t subTexelPrecisionBits;
	public uint32_t mipmapPrecisionBits;
	public uint32_t maxDrawIndexedIndexValue;
	public uint32_t maxDrawIndirectCount;
	public float maxSamplerLodBias;
	public float maxSamplerAnisotropy;
	public uint32_t maxViewports;
	public uint32_t maxViewportDimensions_0;
	public uint32_t maxViewportDimensions_1;
	public fixed float viewportBoundsRange[];
	public uint32_t viewportSubPixelBits;
	public size_t minMemoryMapAlignment;
	public VkDeviceSize minTexelBufferOffsetAlignment;
	public VkDeviceSize minUniformBufferOffsetAlignment;
	public VkDeviceSize minStorageBufferOffsetAlignment;
	public int32_t minTexelOffset;
	public uint32_t maxTexelOffset;
	public int32_t minTexelGatherOffset;
	public uint32_t maxTexelGatherOffset;
	public float minInterpolationOffset;
	public float maxInterpolationOffset;
	public uint32_t subPixelInterpolationOffsetBits;
	public uint32_t maxFramebufferWidth;
	public uint32_t maxFramebufferHeight;
	public uint32_t maxFramebufferLayers;
	public VkSampleCountFlags framebufferColorSampleCounts;
	public VkSampleCountFlags framebufferDepthSampleCounts;
	public VkSampleCountFlags framebufferStencilSampleCounts;
	public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
	public uint32_t maxColorAttachments;
	public VkSampleCountFlags sampledImageColorSampleCounts;
	public VkSampleCountFlags sampledImageIntegerSampleCounts;
	public VkSampleCountFlags sampledImageDepthSampleCounts;
	public VkSampleCountFlags sampledImageStencilSampleCounts;
	public VkSampleCountFlags storageImageSampleCounts;
	public uint32_t maxSampleMaskWords;
	public VkBool32 timestampComputeAndGraphics;
	public float timestampPeriod;
	public uint32_t maxClipDistances;
	public uint32_t maxCullDistances;
	public uint32_t maxCombinedClipAndCullDistances;
	public uint32_t discreteQueuePriorities;
	public fixed float pointSizeRange[];
	public fixed float lineWidthRange[];
	public float pointSizeGranularity;
	public float lineWidthGranularity;
	public VkBool32 strictLines;
	public VkBool32 standardSampleLocations;
	public VkDeviceSize optimalBufferCopyOffsetAlignment;
	public VkDeviceSize optimalBufferCopyRowPitchAlignment;
	public VkDeviceSize nonCoherentAtomSize;
}
public unsafe struct VkPhysicalDeviceSparseProperties
{
	public VkBool32 residencyStandard2DBlockShape;
	public VkBool32 residencyStandard2DMultisampleBlockShape;
	public VkBool32 residencyStandard3DBlockShape;
	public VkBool32 residencyAlignedMipSize;
	public VkBool32 residencyNonResidentStrict;
}
public unsafe struct VkQueueFamilyProperties
{
	public VkQueueFlags queueFlags;
	public uint32_t queueCount;
	public uint32_t timestampValidBits;
	public VkExtent3D minImageTransferGranularity;
}
public unsafe struct VkPhysicalDeviceMemoryProperties
{
	public uint32_t memoryTypeCount;
	public VkMemoryType memoryTypes_0;
	public VkMemoryType memoryTypes_1;
	public VkMemoryType memoryTypes_2;
	public VkMemoryType memoryTypes_3;
	public VkMemoryType memoryTypes_4;
	public VkMemoryType memoryTypes_5;
	public VkMemoryType memoryTypes_6;
	public VkMemoryType memoryTypes_7;
	public VkMemoryType memoryTypes_8;
	public VkMemoryType memoryTypes_9;
	public VkMemoryType memoryTypes_10;
	public VkMemoryType memoryTypes_11;
	public VkMemoryType memoryTypes_12;
	public VkMemoryType memoryTypes_13;
	public VkMemoryType memoryTypes_14;
	public VkMemoryType memoryTypes_15;
	public VkMemoryType memoryTypes_16;
	public VkMemoryType memoryTypes_17;
	public VkMemoryType memoryTypes_18;
	public VkMemoryType memoryTypes_19;
	public VkMemoryType memoryTypes_20;
	public VkMemoryType memoryTypes_21;
	public VkMemoryType memoryTypes_22;
	public VkMemoryType memoryTypes_23;
	public VkMemoryType memoryTypes_24;
	public VkMemoryType memoryTypes_25;
	public VkMemoryType memoryTypes_26;
	public VkMemoryType memoryTypes_27;
	public VkMemoryType memoryTypes_28;
	public VkMemoryType memoryTypes_29;
	public VkMemoryType memoryTypes_30;
	public VkMemoryType memoryTypes_31;
	public uint32_t memoryHeapCount;
	public VkMemoryHeap memoryHeaps_0;
	public VkMemoryHeap memoryHeaps_1;
	public VkMemoryHeap memoryHeaps_2;
	public VkMemoryHeap memoryHeaps_3;
	public VkMemoryHeap memoryHeaps_4;
	public VkMemoryHeap memoryHeaps_5;
	public VkMemoryHeap memoryHeaps_6;
	public VkMemoryHeap memoryHeaps_7;
	public VkMemoryHeap memoryHeaps_8;
	public VkMemoryHeap memoryHeaps_9;
	public VkMemoryHeap memoryHeaps_10;
	public VkMemoryHeap memoryHeaps_11;
	public VkMemoryHeap memoryHeaps_12;
	public VkMemoryHeap memoryHeaps_13;
	public VkMemoryHeap memoryHeaps_14;
	public VkMemoryHeap memoryHeaps_15;
}
public unsafe struct VkMemoryType
{
	public VkMemoryPropertyFlags propertyFlags;
	public uint32_t heapIndex;
}
public unsafe struct VkMemoryHeap
{
	public VkDeviceSize size;
	public VkMemoryHeapFlags flags;
}
public unsafe struct VkDeviceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceCreateFlags flags;
	public uint32_t queueCreateInfoCount;
	public VkDeviceQueueCreateInfo* pQueueCreateInfos;
	public uint32_t enabledLayerCount;
	public char** ppEnabledLayerNames;
	public uint32_t enabledExtensionCount;
	public char** ppEnabledExtensionNames;
	public VkPhysicalDeviceFeatures* pEnabledFeatures;
}
public unsafe struct VkDeviceQueueCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint32_t queueFamilyIndex;
	public uint32_t queueCount;
	public float* pQueuePriorities;
}
public unsafe struct VkExtensionProperties
{
	public fixed char extensionName[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public uint32_t specVersion;
}
public unsafe struct VkLayerProperties
{
	public fixed char layerName[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public uint32_t specVersion;
	public uint32_t implementationVersion;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
}
public unsafe struct VkSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public VkPipelineStageFlags* pWaitDstStageMask;
	public uint32_t commandBufferCount;
	public VkCommandBuffer* pCommandBuffers;
	public uint32_t signalSemaphoreCount;
	public VkSemaphore* pSignalSemaphores;
}
public unsafe struct VkMemoryAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize allocationSize;
	public uint32_t memoryTypeIndex;
}
public unsafe struct VkMappedMemoryRange
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
public unsafe struct VkMemoryRequirements
{
	public VkDeviceSize size;
	public VkDeviceSize alignment;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkSparseImageMemoryRequirements
{
	public VkSparseImageFormatProperties formatProperties;
	public uint32_t imageMipTailFirstLod;
	public VkDeviceSize imageMipTailSize;
	public VkDeviceSize imageMipTailOffset;
	public VkDeviceSize imageMipTailStride;
}
public unsafe struct VkSparseImageFormatProperties
{
	public VkImageAspectFlags aspectMask;
	public VkExtent3D imageGranularity;
	public VkSparseImageFormatFlags flags;
}
public unsafe struct VkBindSparseInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public uint32_t bufferBindCount;
	public VkSparseBufferMemoryBindInfo* pBufferBinds;
	public uint32_t imageOpaqueBindCount;
	public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
	public uint32_t imageBindCount;
	public VkSparseImageMemoryBindInfo* pImageBinds;
	public uint32_t signalSemaphoreCount;
	public VkSemaphore* pSignalSemaphores;
}
public unsafe struct VkSparseBufferMemoryBindInfo
{
	public VkBuffer buffer;
	public uint32_t bindCount;
	public VkSparseMemoryBind* pBinds;
}
public unsafe struct VkSparseMemoryBind
{
	public VkDeviceSize resourceOffset;
	public VkDeviceSize size;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public VkSparseMemoryBindFlags flags;
}
public unsafe struct VkSparseImageOpaqueMemoryBindInfo
{
	public VkImage image;
	public uint32_t bindCount;
	public VkSparseMemoryBind* pBinds;
}
public unsafe struct VkSparseImageMemoryBindInfo
{
	public VkImage image;
	public uint32_t bindCount;
	public VkSparseImageMemoryBind* pBinds;
}
public unsafe struct VkSparseImageMemoryBind
{
	public VkImageSubresource subresource;
	public VkOffset3D offset;
	public VkExtent3D extent;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public VkSparseMemoryBindFlags flags;
}
public unsafe struct VkImageSubresource
{
	public VkImageAspectFlags aspectMask;
	public uint32_t mipLevel;
	public uint32_t arrayLayer;
}
public unsafe struct VkFenceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFenceCreateFlags flags;
}
public unsafe struct VkSemaphoreCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreCreateFlags flags;
}
public unsafe struct VkEventCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkEventCreateFlags flags;
}
public unsafe struct VkQueryPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolCreateFlags flags;
	public VkQueryType queryType;
	public uint32_t queryCount;
	public VkQueryPipelineStatisticFlags pipelineStatistics;
}
public unsafe struct VkBufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkDeviceSize size;
	public VkBufferUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
}
public unsafe struct VkBufferViewCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferViewCreateFlags flags;
	public VkBuffer buffer;
	public VkFormat format;
	public VkDeviceSize offset;
	public VkDeviceSize range;
}
public unsafe struct VkImageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageType imageType;
	public VkFormat format;
	public VkExtent3D extent;
	public uint32_t mipLevels;
	public uint32_t arrayLayers;
	public VkSampleCountFlagBits samples;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkSharingMode sharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
	public VkImageLayout initialLayout;
}
public unsafe struct VkSubresourceLayout
{
	public VkDeviceSize offset;
	public VkDeviceSize size;
	public VkDeviceSize rowPitch;
	public VkDeviceSize arrayPitch;
	public VkDeviceSize depthPitch;
}
public unsafe struct VkImageViewCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageViewCreateFlags flags;
	public VkImage image;
	public VkImageViewType viewType;
	public VkFormat format;
	public VkComponentMapping components;
	public VkImageSubresourceRange subresourceRange;
}
public unsafe struct VkComponentMapping
{
	public VkComponentSwizzle r;
	public VkComponentSwizzle g;
	public VkComponentSwizzle b;
	public VkComponentSwizzle a;
}
public unsafe struct VkShaderModuleCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderModuleCreateFlags flags;
	public size_t codeSize;
	public uint32_t* pCode;
}
public unsafe struct VkPipelineCacheCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCacheCreateFlags flags;
	public size_t initialDataSize;
	public void* pInitialData;
}
public unsafe struct VkGraphicsPipelineCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint32_t stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
	public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
	public VkPipelineTessellationStateCreateInfo* pTessellationState;
	public VkPipelineViewportStateCreateInfo* pViewportState;
	public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
	public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
	public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
	public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
	public VkPipelineDynamicStateCreateInfo* pDynamicState;
	public VkPipelineLayout layout;
	public VkRenderPass renderPass;
	public uint32_t subpass;
	public VkPipeline basePipelineHandle;
	public int32_t basePipelineIndex;
}
public unsafe struct VkPipelineShaderStageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineShaderStageCreateFlags flags;
	public VkShaderStageFlagBits stage;
	public VkShaderModule module;
	public char* pName;
	public VkSpecializationInfo* pSpecializationInfo;
}
public unsafe struct VkSpecializationInfo
{
	public uint32_t mapEntryCount;
	public VkSpecializationMapEntry* pMapEntries;
	public size_t dataSize;
	public void* pData;
}
public unsafe struct VkSpecializationMapEntry
{
	public uint32_t constantID;
	public uint32_t offset;
	public size_t size;
}
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineVertexInputStateCreateFlags flags;
	public uint32_t vertexBindingDescriptionCount;
	public VkVertexInputBindingDescription* pVertexBindingDescriptions;
	public uint32_t vertexAttributeDescriptionCount;
	public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
}
public unsafe struct VkVertexInputBindingDescription
{
	public uint32_t binding;
	public uint32_t stride;
	public VkVertexInputRate inputRate;
}
public unsafe struct VkVertexInputAttributeDescription
{
	public uint32_t location;
	public uint32_t binding;
	public VkFormat format;
	public uint32_t offset;
}
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineInputAssemblyStateCreateFlags flags;
	public VkPrimitiveTopology topology;
	public VkBool32 primitiveRestartEnable;
}
public unsafe struct VkPipelineTessellationStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineTessellationStateCreateFlags flags;
	public uint32_t patchControlPoints;
}
public unsafe struct VkPipelineViewportStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineViewportStateCreateFlags flags;
	public uint32_t viewportCount;
	public VkViewport* pViewports;
	public uint32_t scissorCount;
	public VkRect2D* pScissors;
}
public unsafe struct VkViewport
{
	public float x;
	public float y;
	public float width;
	public float height;
	public float minDepth;
	public float maxDepth;
}
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationStateCreateFlags flags;
	public VkBool32 depthClampEnable;
	public VkBool32 rasterizerDiscardEnable;
	public VkPolygonMode polygonMode;
	public VkCullModeFlags cullMode;
	public VkFrontFace frontFace;
	public VkBool32 depthBiasEnable;
	public float depthBiasConstantFactor;
	public float depthBiasClamp;
	public float depthBiasSlopeFactor;
	public float lineWidth;
}
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineMultisampleStateCreateFlags flags;
	public VkSampleCountFlagBits rasterizationSamples;
	public VkBool32 sampleShadingEnable;
	public float minSampleShading;
	public VkSampleMask* pSampleMask;
	public VkBool32 alphaToCoverageEnable;
	public VkBool32 alphaToOneEnable;
}
public unsafe struct VkPipelineDepthStencilStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDepthStencilStateCreateFlags flags;
	public VkBool32 depthTestEnable;
	public VkBool32 depthWriteEnable;
	public VkCompareOp depthCompareOp;
	public VkBool32 depthBoundsTestEnable;
	public VkBool32 stencilTestEnable;
	public VkStencilOpState front;
	public VkStencilOpState back;
	public float minDepthBounds;
	public float maxDepthBounds;
}
public unsafe struct VkStencilOpState
{
	public VkStencilOp failOp;
	public VkStencilOp passOp;
	public VkStencilOp depthFailOp;
	public VkCompareOp compareOp;
	public uint32_t compareMask;
	public uint32_t writeMask;
	public uint32_t reference;
}
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineColorBlendStateCreateFlags flags;
	public VkBool32 logicOpEnable;
	public VkLogicOp logicOp;
	public uint32_t attachmentCount;
	public VkPipelineColorBlendAttachmentState* pAttachments;
	public fixed float blendConstants[];
}
public unsafe struct VkPipelineColorBlendAttachmentState
{
	public VkBool32 blendEnable;
	public VkBlendFactor srcColorBlendFactor;
	public VkBlendFactor dstColorBlendFactor;
	public VkBlendOp colorBlendOp;
	public VkBlendFactor srcAlphaBlendFactor;
	public VkBlendFactor dstAlphaBlendFactor;
	public VkBlendOp alphaBlendOp;
	public VkColorComponentFlags colorWriteMask;
}
public unsafe struct VkPipelineDynamicStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDynamicStateCreateFlags flags;
	public uint32_t dynamicStateCount;
	public VkDynamicState* pDynamicStates;
}
public unsafe struct VkComputePipelineCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public VkPipelineShaderStageCreateInfo stage;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int32_t basePipelineIndex;
}
public unsafe struct VkPipelineLayoutCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineLayoutCreateFlags flags;
	public uint32_t setLayoutCount;
	public VkDescriptorSetLayout* pSetLayouts;
	public uint32_t pushConstantRangeCount;
	public VkPushConstantRange* pPushConstantRanges;
}
public unsafe struct VkPushConstantRange
{
	public VkShaderStageFlags stageFlags;
	public uint32_t offset;
	public uint32_t size;
}
public unsafe struct VkSamplerCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerCreateFlags flags;
	public VkFilter magFilter;
	public VkFilter minFilter;
	public VkSamplerMipmapMode mipmapMode;
	public VkSamplerAddressMode addressModeU;
	public VkSamplerAddressMode addressModeV;
	public VkSamplerAddressMode addressModeW;
	public float mipLodBias;
	public VkBool32 anisotropyEnable;
	public float maxAnisotropy;
	public VkBool32 compareEnable;
	public VkCompareOp compareOp;
	public float minLod;
	public float maxLod;
	public VkBorderColor borderColor;
	public VkBool32 unnormalizedCoordinates;
}
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSetLayoutCreateFlags flags;
	public uint32_t bindingCount;
	public VkDescriptorSetLayoutBinding* pBindings;
}
public unsafe struct VkDescriptorSetLayoutBinding
{
	public uint32_t binding;
	public VkDescriptorType descriptorType;
	public uint32_t descriptorCount;
	public VkShaderStageFlags stageFlags;
	public VkSampler* pImmutableSamplers;
}
public unsafe struct VkDescriptorPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorPoolCreateFlags flags;
	public uint32_t maxSets;
	public uint32_t poolSizeCount;
	public VkDescriptorPoolSize* pPoolSizes;
}
public unsafe struct VkDescriptorPoolSize
{
	public VkDescriptorType type;
	public uint32_t descriptorCount;
}
public unsafe struct VkDescriptorSetAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorPool descriptorPool;
	public uint32_t descriptorSetCount;
	public VkDescriptorSetLayout* pSetLayouts;
}
public unsafe struct VkWriteDescriptorSet
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSet dstSet;
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
	public VkDescriptorType descriptorType;
	public VkDescriptorImageInfo* pImageInfo;
	public VkDescriptorBufferInfo* pBufferInfo;
	public VkBufferView* pTexelBufferView;
}
public unsafe struct VkDescriptorImageInfo
{
	public VkSampler sampler;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
}
public unsafe struct VkDescriptorBufferInfo
{
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize range;
}
public unsafe struct VkCopyDescriptorSet
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSet srcSet;
	public uint32_t srcBinding;
	public uint32_t srcArrayElement;
	public VkDescriptorSet dstSet;
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
}
public unsafe struct VkFramebufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFramebufferCreateFlags flags;
	public VkRenderPass renderPass;
	public uint32_t attachmentCount;
	public VkImageView* pAttachments;
	public uint32_t width;
	public uint32_t height;
	public uint32_t layers;
}
public unsafe struct VkRenderPassCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint32_t attachmentCount;
	public VkAttachmentDescription* pAttachments;
	public uint32_t subpassCount;
	public VkSubpassDescription* pSubpasses;
	public uint32_t dependencyCount;
	public VkSubpassDependency* pDependencies;
}
public unsafe struct VkAttachmentDescription
{
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlagBits samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}
public unsafe struct VkSubpassDescription
{
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint32_t inputAttachmentCount;
	public VkAttachmentReference* pInputAttachments;
	public uint32_t colorAttachmentCount;
	public VkAttachmentReference* pColorAttachments;
	public VkAttachmentReference* pResolveAttachments;
	public VkAttachmentReference* pDepthStencilAttachment;
	public uint32_t preserveAttachmentCount;
	public uint32_t* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference
{
	public uint32_t attachment;
	public VkImageLayout layout;
}
public unsafe struct VkSubpassDependency
{
	public uint32_t srcSubpass;
	public uint32_t dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
}
public unsafe struct VkCommandPoolCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandPoolCreateFlags flags;
	public uint32_t queueFamilyIndex;
}
public unsafe struct VkCommandBufferAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandPool commandPool;
	public VkCommandBufferLevel level;
	public uint32_t commandBufferCount;
}
public unsafe struct VkCommandBufferBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandBufferUsageFlags flags;
	public VkCommandBufferInheritanceInfo* pInheritanceInfo;
}
public unsafe struct VkCommandBufferInheritanceInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPass renderPass;
	public uint32_t subpass;
	public VkFramebuffer framebuffer;
	public VkBool32 occlusionQueryEnable;
	public VkQueryControlFlags queryFlags;
	public VkQueryPipelineStatisticFlags pipelineStatistics;
}
public unsafe struct VkBufferCopy
{
	public VkDeviceSize srcOffset;
	public VkDeviceSize dstOffset;
	public VkDeviceSize size;
}
public unsafe struct VkImageCopy
{
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkImageSubresourceLayers
{
	public VkImageAspectFlags aspectMask;
	public uint32_t mipLevel;
	public uint32_t baseArrayLayer;
	public uint32_t layerCount;
}
public unsafe struct VkImageBlit
{
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffsets_0;
	public VkOffset3D srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffsets_0;
	public VkOffset3D dstOffsets_1;
}
public unsafe struct VkBufferImageCopy
{
	public VkDeviceSize bufferOffset;
	public uint32_t bufferRowLength;
	public uint32_t bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearColorValue
{
	[FieldOffset(0)]
	public fixed float float32[];
	[FieldOffset(0)]
	public int32_t int32_0;
	public int32_t int32_1;
	public int32_t int32_2;
	public int32_t int32_3;
	[FieldOffset(0)]
	public uint32_t uint32_0;
	public uint32_t uint32_1;
	public uint32_t uint32_2;
	public uint32_t uint32_3;
}
public unsafe struct VkClearDepthStencilValue
{
	public float depth;
	public uint32_t stencil;
}
public unsafe struct VkClearAttachment
{
	public VkImageAspectFlags aspectMask;
	public uint32_t colorAttachment;
	public VkClearValue clearValue;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkClearValue
{
	[FieldOffset(0)]
	public VkClearColorValue color;
	[FieldOffset(0)]
	public VkClearDepthStencilValue depthStencil;
}
public unsafe struct VkClearRect
{
	public VkRect2D rect;
	public uint32_t baseArrayLayer;
	public uint32_t layerCount;
}
public unsafe struct VkImageResolve
{
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkRenderPassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPass renderPass;
	public VkFramebuffer framebuffer;
	public VkRect2D renderArea;
	public uint32_t clearValueCount;
	public VkClearValue* pClearValues;
}
public unsafe struct VkPhysicalDeviceSubgroupProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t subgroupSize;
	public VkShaderStageFlags supportedStages;
	public VkSubgroupFeatureFlags supportedOperations;
	public VkBool32 quadOperationsInAllStages;
}
public unsafe struct VkBindBufferMemoryInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkBindImageMemoryInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkPhysicalDevice16BitStorageFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
}
public unsafe struct VkMemoryDedicatedRequirements
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 prefersDedicatedAllocation;
	public VkBool32 requiresDedicatedAllocation;
}
public unsafe struct VkMemoryDedicatedAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}
public unsafe struct VkMemoryAllocateFlagsInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryAllocateFlags flags;
	public uint32_t deviceMask;
}
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
	public uint32_t deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
public unsafe struct VkDeviceGroupCommandBufferBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
}
public unsafe struct VkDeviceGroupSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public uint32_t* pWaitSemaphoreDeviceIndices;
	public uint32_t commandBufferCount;
	public uint32_t* pCommandBufferDeviceMasks;
	public uint32_t signalSemaphoreCount;
	public uint32_t* pSignalSemaphoreDeviceIndices;
}
public unsafe struct VkDeviceGroupBindSparseInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t resourceDeviceIndex;
	public uint32_t memoryDeviceIndex;
}
public unsafe struct VkBindBufferMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
}
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
	public uint32_t splitInstanceBindRegionCount;
	public VkRect2D* pSplitInstanceBindRegions;
}
public unsafe struct VkPhysicalDeviceGroupProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t physicalDeviceCount;
	public VkPhysicalDevice physicalDevices_0;
	public VkPhysicalDevice physicalDevices_1;
	public VkPhysicalDevice physicalDevices_2;
	public VkPhysicalDevice physicalDevices_3;
	public VkPhysicalDevice physicalDevices_4;
	public VkPhysicalDevice physicalDevices_5;
	public VkPhysicalDevice physicalDevices_6;
	public VkPhysicalDevice physicalDevices_7;
	public VkPhysicalDevice physicalDevices_8;
	public VkPhysicalDevice physicalDevices_9;
	public VkPhysicalDevice physicalDevices_10;
	public VkPhysicalDevice physicalDevices_11;
	public VkPhysicalDevice physicalDevices_12;
	public VkPhysicalDevice physicalDevices_13;
	public VkPhysicalDevice physicalDevices_14;
	public VkPhysicalDevice physicalDevices_15;
	public VkPhysicalDevice physicalDevices_16;
	public VkPhysicalDevice physicalDevices_17;
	public VkPhysicalDevice physicalDevices_18;
	public VkPhysicalDevice physicalDevices_19;
	public VkPhysicalDevice physicalDevices_20;
	public VkPhysicalDevice physicalDevices_21;
	public VkPhysicalDevice physicalDevices_22;
	public VkPhysicalDevice physicalDevices_23;
	public VkPhysicalDevice physicalDevices_24;
	public VkPhysicalDevice physicalDevices_25;
	public VkPhysicalDevice physicalDevices_26;
	public VkPhysicalDevice physicalDevices_27;
	public VkPhysicalDevice physicalDevices_28;
	public VkPhysicalDevice physicalDevices_29;
	public VkPhysicalDevice physicalDevices_30;
	public VkPhysicalDevice physicalDevices_31;
	public VkBool32 subsetAllocation;
}
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t physicalDeviceCount;
	public VkPhysicalDevice* pPhysicalDevices;
}
public unsafe struct VkImageMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkMemoryRequirements2
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryRequirements memoryRequirements;
}
public unsafe struct VkBufferMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkSparseImageMemoryRequirements2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageMemoryRequirements memoryRequirements;
}
public unsafe struct VkPhysicalDeviceFeatures2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceFeatures features;
}
public unsafe struct VkPhysicalDeviceProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceProperties properties;
}
public unsafe struct VkFormatProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatProperties formatProperties;
}
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkImageCreateFlags flags;
}
public unsafe struct VkImageFormatProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageFormatProperties imageFormatProperties;
}
public unsafe struct VkQueueFamilyProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFamilyProperties queueFamilyProperties;
}
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceMemoryProperties memoryProperties;
}
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkSampleCountFlagBits samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}
public unsafe struct VkSparseImageFormatProperties2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageFormatProperties properties;
}
public unsafe struct VkPhysicalDevicePointClippingProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkPointClippingBehavior pointClippingBehavior;
}
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t aspectReferenceCount;
	public VkInputAttachmentAspectReference* pAspectReferences;
}
public unsafe struct VkInputAttachmentAspectReference
{
	public uint32_t subpass;
	public uint32_t inputAttachmentIndex;
	public VkImageAspectFlags aspectMask;
}
public unsafe struct VkImageViewUsageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags usage;
}
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkTessellationDomainOrigin domainOrigin;
}
public unsafe struct VkRenderPassMultiviewCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t subpassCount;
	public uint32_t* pViewMasks;
	public uint32_t dependencyCount;
	public int32_t* pViewOffsets;
	public uint32_t correlationMaskCount;
	public uint32_t* pCorrelationMasks;
}
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
}
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxMultiviewViewCount;
	public uint32_t maxMultiviewInstanceIndex;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointerFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkDeviceQueueInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceQueueCreateFlags flags;
	public uint32_t queueFamilyIndex;
	public uint32_t queueIndex;
}
public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 protectedMemory;
}
public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 protectedNoFault;
}
public unsafe struct VkProtectedSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 protectedSubmit;
}
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkSamplerYcbcrModelConversion ycbcrModel;
	public VkSamplerYcbcrRange ycbcrRange;
	public VkComponentMapping components;
	public VkChromaLocation xChromaOffset;
	public VkChromaLocation yChromaOffset;
	public VkFilter chromaFilter;
	public VkBool32 forceExplicitReconstruction;
}
public unsafe struct VkSamplerYcbcrConversionInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerYcbcrConversion conversion;
}
public unsafe struct VkBindImagePlaneMemoryInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerYcbcrConversion;
}
public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t combinedImageSamplerDescriptorCount;
}
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint32_t descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint32_t set;
}
public unsafe struct VkDescriptorUpdateTemplateEntry
{
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
	public VkDescriptorType descriptorType;
	public size_t offset;
	public size_t stride;
}
public unsafe struct VkPhysicalDeviceExternalBufferInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkExternalBufferProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
public unsafe struct VkExternalMemoryProperties
{
	public VkExternalMemoryFeatureFlags externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}
public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkExternalImageFormatProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
public unsafe struct VkPhysicalDeviceIDProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t deviceUUID_0;
	public uint8_t deviceUUID_1;
	public uint8_t deviceUUID_2;
	public uint8_t deviceUUID_3;
	public uint8_t deviceUUID_4;
	public uint8_t deviceUUID_5;
	public uint8_t deviceUUID_6;
	public uint8_t deviceUUID_7;
	public uint8_t deviceUUID_8;
	public uint8_t deviceUUID_9;
	public uint8_t deviceUUID_10;
	public uint8_t deviceUUID_11;
	public uint8_t deviceUUID_12;
	public uint8_t deviceUUID_13;
	public uint8_t deviceUUID_14;
	public uint8_t deviceUUID_15;
	public uint8_t driverUUID_0;
	public uint8_t driverUUID_1;
	public uint8_t driverUUID_2;
	public uint8_t driverUUID_3;
	public uint8_t driverUUID_4;
	public uint8_t driverUUID_5;
	public uint8_t driverUUID_6;
	public uint8_t driverUUID_7;
	public uint8_t driverUUID_8;
	public uint8_t driverUUID_9;
	public uint8_t driverUUID_10;
	public uint8_t driverUUID_11;
	public uint8_t driverUUID_12;
	public uint8_t driverUUID_13;
	public uint8_t driverUUID_14;
	public uint8_t driverUUID_15;
	public uint8_t deviceLUID_0;
	public uint8_t deviceLUID_1;
	public uint8_t deviceLUID_2;
	public uint8_t deviceLUID_3;
	public uint8_t deviceLUID_4;
	public uint8_t deviceLUID_5;
	public uint8_t deviceLUID_6;
	public uint8_t deviceLUID_7;
	public uint32_t deviceNodeMask;
	public VkBool32 deviceLUIDValid;
}
public unsafe struct VkExternalMemoryImageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkExternalMemoryBufferCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkExportMemoryAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkPhysicalDeviceExternalFenceInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlagBits handleType;
}
public unsafe struct VkExternalFenceProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
	public VkExternalFenceFeatureFlags externalFenceFeatures;
}
public unsafe struct VkExportFenceCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags handleTypes;
}
public unsafe struct VkExportSemaphoreCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleTypes;
}
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
}
public unsafe struct VkExternalSemaphoreProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}
public unsafe struct VkDescriptorSetLayoutSupport
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supported;
}
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxPerSetDescriptors;
	public VkDeviceSize maxMemoryAllocationSize;
}
[Obsolete("Use VkPhysicalDeviceShaderDrawParametersFeatures")]
public unsafe struct VkPhysicalDeviceShaderDrawParameterFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceVulkan11Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
	public VkBool32 protectedMemory;
	public VkBool32 samplerYcbcrConversion;
	public VkBool32 shaderDrawParameters;
}
public unsafe struct VkPhysicalDeviceVulkan11Properties
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t deviceUUID_0;
	public uint8_t deviceUUID_1;
	public uint8_t deviceUUID_2;
	public uint8_t deviceUUID_3;
	public uint8_t deviceUUID_4;
	public uint8_t deviceUUID_5;
	public uint8_t deviceUUID_6;
	public uint8_t deviceUUID_7;
	public uint8_t deviceUUID_8;
	public uint8_t deviceUUID_9;
	public uint8_t deviceUUID_10;
	public uint8_t deviceUUID_11;
	public uint8_t deviceUUID_12;
	public uint8_t deviceUUID_13;
	public uint8_t deviceUUID_14;
	public uint8_t deviceUUID_15;
	public uint8_t driverUUID_0;
	public uint8_t driverUUID_1;
	public uint8_t driverUUID_2;
	public uint8_t driverUUID_3;
	public uint8_t driverUUID_4;
	public uint8_t driverUUID_5;
	public uint8_t driverUUID_6;
	public uint8_t driverUUID_7;
	public uint8_t driverUUID_8;
	public uint8_t driverUUID_9;
	public uint8_t driverUUID_10;
	public uint8_t driverUUID_11;
	public uint8_t driverUUID_12;
	public uint8_t driverUUID_13;
	public uint8_t driverUUID_14;
	public uint8_t driverUUID_15;
	public uint8_t deviceLUID_0;
	public uint8_t deviceLUID_1;
	public uint8_t deviceLUID_2;
	public uint8_t deviceLUID_3;
	public uint8_t deviceLUID_4;
	public uint8_t deviceLUID_5;
	public uint8_t deviceLUID_6;
	public uint8_t deviceLUID_7;
	public uint32_t deviceNodeMask;
	public VkBool32 deviceLUIDValid;
	public uint32_t subgroupSize;
	public VkShaderStageFlags subgroupSupportedStages;
	public VkSubgroupFeatureFlags subgroupSupportedOperations;
	public VkBool32 subgroupQuadOperationsInAllStages;
	public VkPointClippingBehavior pointClippingBehavior;
	public uint32_t maxMultiviewViewCount;
	public uint32_t maxMultiviewInstanceIndex;
	public VkBool32 protectedNoFault;
	public uint32_t maxPerSetDescriptors;
	public VkDeviceSize maxMemoryAllocationSize;
}
public unsafe struct VkPhysicalDeviceVulkan12Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerMirrorClampToEdge;
	public VkBool32 drawIndirectCount;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
	public VkBool32 descriptorIndexing;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
	public VkBool32 samplerFilterMinmax;
	public VkBool32 scalarBlockLayout;
	public VkBool32 imagelessFramebuffer;
	public VkBool32 uniformBufferStandardLayout;
	public VkBool32 shaderSubgroupExtendedTypes;
	public VkBool32 separateDepthStencilLayouts;
	public VkBool32 hostQueryReset;
	public VkBool32 timelineSemaphore;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
	public VkBool32 shaderOutputViewportIndex;
	public VkBool32 shaderOutputLayer;
	public VkBool32 subgroupBroadcastDynamicId;
}
public unsafe struct VkPhysicalDeviceVulkan12Properties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverId driverID;
	public fixed char driverName[VK.VK_MAX_DRIVER_NAME_SIZE];
	public fixed char driverInfo[VK.VK_MAX_DRIVER_INFO_SIZE];
	public VkConformanceVersion conformanceVersion;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
	public uint32_t maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint32_t maxPerStageUpdateAfterBindResources;
	public uint32_t maxDescriptorSetUpdateAfterBindSamplers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindSampledImages;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageImages;
	public uint32_t maxDescriptorSetUpdateAfterBindInputAttachments;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
	public uint64_t maxTimelineSemaphoreValueDifference;
	public VkSampleCountFlags framebufferIntegerColorSampleCounts;
}
public unsafe struct VkConformanceVersion
{
	public uint8_t major;
	public uint8_t minor;
	public uint8_t subminor;
	public uint8_t patch;
}
public unsafe struct VkImageFormatListCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkRenderPassCreateInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint32_t attachmentCount;
	public VkAttachmentDescription2* pAttachments;
	public uint32_t subpassCount;
	public VkSubpassDescription2* pSubpasses;
	public uint32_t dependencyCount;
	public VkSubpassDependency2* pDependencies;
	public uint32_t correlatedViewMaskCount;
	public uint32_t* pCorrelatedViewMasks;
}
public unsafe struct VkAttachmentDescription2
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlagBits samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}
public unsafe struct VkSubpassDescription2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint32_t viewMask;
	public uint32_t inputAttachmentCount;
	public VkAttachmentReference2* pInputAttachments;
	public uint32_t colorAttachmentCount;
	public VkAttachmentReference2* pColorAttachments;
	public VkAttachmentReference2* pResolveAttachments;
	public VkAttachmentReference2* pDepthStencilAttachment;
	public uint32_t preserveAttachmentCount;
	public uint32_t* pPreserveAttachments;
}
public unsafe struct VkAttachmentReference2
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}
public unsafe struct VkSubpassDependency2
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t srcSubpass;
	public uint32_t dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
	public int32_t viewOffset;
}
public unsafe struct VkSubpassBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassContents contents;
}
public unsafe struct VkSubpassEndInfo
{
	public VkStructureType sType;
	public void* pNext;
}
public unsafe struct VkPhysicalDevice8BitStorageFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
}
public unsafe struct VkPhysicalDeviceDriverProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverId driverID;
	public fixed char driverName[VK.VK_MAX_DRIVER_NAME_SIZE];
	public fixed char driverInfo[VK.VK_MAX_DRIVER_INFO_SIZE];
	public VkConformanceVersion conformanceVersion;
}
public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
}
public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
public unsafe struct VkPhysicalDeviceFloatControlsProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
}
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t bindingCount;
	public VkDescriptorBindingFlags* pBindingFlags;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
}
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint32_t maxPerStageUpdateAfterBindResources;
	public uint32_t maxDescriptorSetUpdateAfterBindSamplers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindSampledImages;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageImages;
	public uint32_t maxDescriptorSetUpdateAfterBindInputAttachments;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t descriptorSetCount;
	public uint32_t* pDescriptorCounts;
}
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxVariableDescriptorCount;
}
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlagBits depthResolveMode;
	public VkResolveModeFlagBits stencilResolveMode;
	public VkAttachmentReference2* pDepthStencilResolveAttachment;
}
public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
}
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 scalarBlockLayout;
}
public unsafe struct VkImageStencilUsageCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags stencilUsage;
}
public unsafe struct VkSamplerReductionModeCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerReductionMode reductionMode;
}
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
}
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
}
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imagelessFramebuffer;
}
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}
public unsafe struct VkFramebufferAttachmentImageInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageUsageFlags usage;
	public uint32_t width;
	public uint32_t height;
	public uint32_t layerCount;
	public uint32_t viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkRenderPassAttachmentBeginInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentCount;
	public VkImageView* pAttachments;
}
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 uniformBufferStandardLayout;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupExtendedTypes;
}
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 separateDepthStencilLayouts;
}
public unsafe struct VkAttachmentReferenceStencilLayout
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilLayout;
}
public unsafe struct VkAttachmentDescriptionStencilLayout
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilInitialLayout;
	public VkImageLayout stencilFinalLayout;
}
public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 hostQueryReset;
}
public unsafe struct VkSemaphoreWaitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreWaitFlags flags;
	public uint32_t semaphoreCount;
	public VkSemaphore* pSemaphores;
	public uint64_t* pValues;
}
public unsafe struct VkSemaphoreSignalInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public uint64_t value;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 timelineSemaphore;
}
public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t maxTimelineSemaphoreValueDifference;
}
public unsafe struct VkSemaphoreTypeCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreType semaphoreType;
	public uint64_t initialValue;
}
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreValueCount;
	public uint64_t* pWaitSemaphoreValues;
	public uint32_t signalSemaphoreValueCount;
	public uint64_t* pSignalSemaphoreValues;
}
public unsafe struct VkBufferDeviceAddressInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t opaqueCaptureAddress;
}
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t opaqueCaptureAddress;
}
public unsafe struct VkPhysicalDeviceVulkan13Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustImageAccess;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
	public VkBool32 pipelineCreationCacheControl;
	public VkBool32 privateData;
	public VkBool32 shaderDemoteToHelperInvocation;
	public VkBool32 shaderTerminateInvocation;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
	public VkBool32 synchronization2;
	public VkBool32 textureCompressionASTC_HDR;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
	public VkBool32 dynamicRendering;
	public VkBool32 shaderIntegerDotProduct;
	public VkBool32 maintenance4;
}
public unsafe struct VkPhysicalDeviceVulkan13Properties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t minSubgroupSize;
	public uint32_t maxSubgroupSize;
	public uint32_t maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
	public uint32_t maxInlineUniformBlockSize;
	public uint32_t maxPerStageDescriptorInlineUniformBlocks;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint32_t maxDescriptorSetInlineUniformBlocks;
	public uint32_t maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	public uint32_t maxInlineUniformTotalSize;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize maxBufferSize;
}
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreationFeedback* pPipelineCreationFeedback;
	public uint32_t pipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedback** pPipelineStageCreationFeedbacks;
}
public unsafe struct VkPipelineCreationFeedback
{
	public VkPipelineCreationFeedbackFlags flags;
	public uint64_t duration;
}
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderTerminateInvocation;
}
public unsafe struct VkPhysicalDeviceToolProperties
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char name[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public fixed char version[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public VkToolPurposeFlags purposes;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char layer[VK.VK_MAX_EXTENSION_NAME_SIZE];
}
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDemoteToHelperInvocation;
}
public unsafe struct VkPrivateDataSlotCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkPrivateDataSlotCreateFlags flags;
}
public unsafe struct VkPhysicalDevicePrivateDataFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 privateData;
}
public unsafe struct VkDevicePrivateDataCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t privateDataSlotRequestCount;
}
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineCreationCacheControl;
}
public unsafe struct VkDependencyInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkDependencyFlags dependencyFlags;
	public uint32_t memoryBarrierCount;
	public VkMemoryBarrier2* pMemoryBarriers;
	public uint32_t bufferMemoryBarrierCount;
	public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
	public uint32_t imageMemoryBarrierCount;
	public VkImageMemoryBarrier2* pImageMemoryBarriers;
}
public unsafe struct VkMemoryBarrier2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
}
public unsafe struct VkBufferMemoryBarrier2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
public unsafe struct VkImageMemoryBarrier2
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}
public unsafe struct VkSubmitInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubmitFlags flags;
	public uint32_t waitSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
	public uint32_t commandBufferInfoCount;
	public VkCommandBufferSubmitInfo* pCommandBufferInfos;
	public uint32_t signalSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}
public unsafe struct VkSemaphoreSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public uint64_t value;
	public VkPipelineStageFlags2 stageMask;
	public uint32_t deviceIndex;
}
public unsafe struct VkCommandBufferSubmitInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandBuffer commandBuffer;
	public uint32_t deviceMask;
}
public unsafe struct VkPhysicalDeviceSynchronization2Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 synchronization2;
}
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
}
public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustImageAccess;
}
public unsafe struct VkCopyBufferInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkBuffer dstBuffer;
	public uint32_t regionCount;
	public VkBufferCopy2* pRegions;
}
public unsafe struct VkBufferCopy2
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize srcOffset;
	public VkDeviceSize dstOffset;
	public VkDeviceSize size;
}
public unsafe struct VkCopyImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkImageCopy2* pRegions;
}
public unsafe struct VkImageCopy2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkCopyBufferToImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkBufferImageCopy2* pRegions;
}
public unsafe struct VkBufferImageCopy2
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize bufferOffset;
	public uint32_t bufferRowLength;
	public uint32_t bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
public unsafe struct VkCopyImageToBufferInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkBuffer dstBuffer;
	public uint32_t regionCount;
	public VkBufferImageCopy2* pRegions;
}
public unsafe struct VkBlitImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkImageBlit2* pRegions;
	public VkFilter filter;
}
public unsafe struct VkImageBlit2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffsets_0;
	public VkOffset3D srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffsets_0;
	public VkOffset3D dstOffsets_1;
}
public unsafe struct VkResolveImageInfo2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkImageResolve2* pRegions;
}
public unsafe struct VkImageResolve2
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
}
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t minSubgroupSize;
	public uint32_t maxSubgroupSize;
	public uint32_t maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t requiredSubgroupSize;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxInlineUniformBlockSize;
	public uint32_t maxPerStageDescriptorInlineUniformBlocks;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint32_t maxDescriptorSetInlineUniformBlocks;
	public uint32_t maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t dataSize;
	public void* pData;
}
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxInlineUniformBlockBindings;
}
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 textureCompressionASTC_HDR;
}
public unsafe struct VkRenderingInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public VkRect2D renderArea;
	public uint32_t layerCount;
	public uint32_t viewMask;
	public uint32_t colorAttachmentCount;
	public VkRenderingAttachmentInfo* pColorAttachments;
	public VkRenderingAttachmentInfo* pDepthAttachment;
	public VkRenderingAttachmentInfo* pStencilAttachment;
}
public unsafe struct VkRenderingAttachmentInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkResolveModeFlagBits resolveMode;
	public VkImageView resolveImageView;
	public VkImageLayout resolveImageLayout;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkClearValue clearValue;
}
public unsafe struct VkPipelineRenderingCreateInfo
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t viewMask;
	public uint32_t colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
}
public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dynamicRendering;
}
public unsafe struct VkCommandBufferInheritanceRenderingInfo
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public uint32_t viewMask;
	public uint32_t colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
	public VkSampleCountFlagBits rasterizationSamples;
}
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderIntegerDotProduct;
}
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}
public unsafe struct VkFormatProperties3
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatFeatureFlags2 linearTilingFeatures;
	public VkFormatFeatureFlags2 optimalTilingFeatures;
	public VkFormatFeatureFlags2 bufferFeatures;
}
public unsafe struct VkDeviceBufferMemoryRequirements
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateInfo* pCreateInfo;
}
public unsafe struct VkDeviceImageMemoryRequirements
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateInfo* pCreateInfo;
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 maintenance4;
}
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize maxBufferSize;
}
public unsafe struct VkSurfaceCapabilitiesKHR
{
	public uint32_t minImageCount;
	public uint32_t maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint32_t maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagBitsKHR currentTransform;
	public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
	public VkImageUsageFlags supportedUsageFlags;
}
public unsafe struct VkSurfaceFormatKHR
{
	public VkFormat format;
	public VkColorSpaceKHR colorSpace;
}
public unsafe struct VkSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainCreateFlagsKHR flags;
	public VkSurfaceKHR surface;
	public uint32_t minImageCount;
	public VkFormat imageFormat;
	public VkColorSpaceKHR imageColorSpace;
	public VkExtent2D imageExtent;
	public uint32_t imageArrayLayers;
	public VkImageUsageFlags imageUsage;
	public VkSharingMode imageSharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
	public VkSurfaceTransformFlagBitsKHR preTransform;
	public VkCompositeAlphaFlagBitsKHR compositeAlpha;
	public VkPresentModeKHR presentMode;
	public VkBool32 clipped;
	public VkSwapchainKHR oldSwapchain;
}
public unsafe struct VkPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public VkSemaphore* pWaitSemaphores;
	public uint32_t swapchainCount;
	public VkSwapchainKHR* pSwapchains;
	public uint32_t* pImageIndices;
	public VkResult* pResults;
}
public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t presentMask_0;
	public uint32_t presentMask_1;
	public uint32_t presentMask_2;
	public uint32_t presentMask_3;
	public uint32_t presentMask_4;
	public uint32_t presentMask_5;
	public uint32_t presentMask_6;
	public uint32_t presentMask_7;
	public uint32_t presentMask_8;
	public uint32_t presentMask_9;
	public uint32_t presentMask_10;
	public uint32_t presentMask_11;
	public uint32_t presentMask_12;
	public uint32_t presentMask_13;
	public uint32_t presentMask_14;
	public uint32_t presentMask_15;
	public uint32_t presentMask_16;
	public uint32_t presentMask_17;
	public uint32_t presentMask_18;
	public uint32_t presentMask_19;
	public uint32_t presentMask_20;
	public uint32_t presentMask_21;
	public uint32_t presentMask_22;
	public uint32_t presentMask_23;
	public uint32_t presentMask_24;
	public uint32_t presentMask_25;
	public uint32_t presentMask_26;
	public uint32_t presentMask_27;
	public uint32_t presentMask_28;
	public uint32_t presentMask_29;
	public uint32_t presentMask_30;
	public uint32_t presentMask_31;
	public VkDeviceGroupPresentModeFlagsKHR modes;
}
public unsafe struct VkAcquireNextImageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint64_t timeout;
	public VkSemaphore semaphore;
	public VkFence fence;
	public uint32_t deviceMask;
}
public unsafe struct VkImageSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
}
public unsafe struct VkBindImageMemorySwapchainInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint32_t imageIndex;
}
public unsafe struct VkDeviceGroupPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public uint32_t* pDeviceMasks;
	public VkDeviceGroupPresentModeFlagBitsKHR mode;
}
public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceGroupPresentModeFlagsKHR modes;
}
public unsafe struct VkDisplayPropertiesKHR
{
	public VkDisplayKHR display;
	public char* displayName;
	public VkExtent2D physicalDimensions;
	public VkExtent2D physicalResolution;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkBool32 planeReorderPossible;
	public VkBool32 persistentContent;
}
public unsafe struct VkDisplayPlanePropertiesKHR
{
	public VkDisplayKHR currentDisplay;
	public uint32_t currentStackIndex;
}
public unsafe struct VkDisplayModePropertiesKHR
{
	public VkDisplayModeKHR displayMode;
	public VkDisplayModeParametersKHR parameters;
}
public unsafe struct VkDisplayModeParametersKHR
{
	public VkExtent2D visibleRegion;
	public uint32_t refreshRate;
}
public unsafe struct VkDisplayModeCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayModeCreateFlagsKHR flags;
	public VkDisplayModeParametersKHR parameters;
}
public unsafe struct VkDisplayPlaneCapabilitiesKHR
{
	public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
	public VkOffset2D minSrcPosition;
	public VkOffset2D maxSrcPosition;
	public VkExtent2D minSrcExtent;
	public VkExtent2D maxSrcExtent;
	public VkOffset2D minDstPosition;
	public VkOffset2D maxDstPosition;
	public VkExtent2D minDstExtent;
	public VkExtent2D maxDstExtent;
}
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplaySurfaceCreateFlagsKHR flags;
	public VkDisplayModeKHR displayMode;
	public uint32_t planeIndex;
	public uint32_t planeStackIndex;
	public VkSurfaceTransformFlagBitsKHR transform;
	public float globalAlpha;
	public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
	public VkExtent2D imageExtent;
}
public unsafe struct VkDisplayPresentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRect2D srcRect;
	public VkRect2D dstRect;
	public VkBool32 persistent;
}
public unsafe struct VkXlibSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkXlibSurfaceCreateFlagsKHR flags;
	public Display* dpy;
	public Window window;
}
public unsafe struct VkXcbSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkXcbSurfaceCreateFlagsKHR flags;
	public xcb_connection_t* connection;
	public xcb_window_t window;
}
public unsafe struct VkWaylandSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkWaylandSurfaceCreateFlagsKHR flags;
	public wl_display* display;
	public wl_surface* surface;
}
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAndroidSurfaceCreateFlagsKHR flags;
	public ANativeWindow* window;
}
public unsafe struct VkWin32SurfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkWin32SurfaceCreateFlagsKHR flags;
	public HINSTANCE hinstance;
	public HWND hwnd;
}
public unsafe struct VkDebugReportCallbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportFlagsEXT flags;
	public PFN_vkDebugReportCallbackEXT pfnCallback;
	public void* pUserData;
}
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkRasterizationOrderAMD rasterizationOrder;
}
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public uint64_t object;
	public uint64_t tagName;
	public size_t tagSize;
	public void* pTag;
}
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugReportObjectTypeEXT objectType;
	public uint64_t object;
	public char* pObjectName;
}
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public char* pMarkerName;
	public fixed float color[];
}
public unsafe struct VkVideoProfileInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCodecOperationFlagBitsKHR videoCodecOperation;
	public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
	public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
	public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
}
public unsafe struct VkVideoCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCapabilityFlagsKHR flags;
	public VkDeviceSize minBitstreamBufferOffsetAlignment;
	public VkDeviceSize minBitstreamBufferSizeAlignment;
	public VkExtent2D pictureAccessGranularity;
	public VkExtent2D minCodedExtent;
	public VkExtent2D maxCodedExtent;
	public uint32_t maxDpbSlots;
	public uint32_t maxActiveReferencePictures;
	public VkExtensionProperties stdHeaderVersion;
}
public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags imageUsage;
}
public unsafe struct VkVideoFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkComponentMapping componentMapping;
	public VkImageCreateFlags imageCreateFlags;
	public VkImageType imageType;
	public VkImageTiling imageTiling;
	public VkImageUsageFlags imageUsageFlags;
}
public unsafe struct VkVideoSessionCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t queueFamilyIndex;
	public VkVideoSessionCreateFlagsKHR flags;
	public VkVideoProfileInfoKHR* pVideoProfile;
	public VkFormat pictureFormat;
	public VkExtent2D maxCodedExtent;
	public VkFormat referencePictureFormat;
	public uint32_t maxDpbSlots;
	public uint32_t maxActiveReferencePictures;
	public VkExtensionProperties* pStdHeaderVersion;
}
public unsafe struct VkVideoSessionMemoryRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryBindIndex;
	public VkMemoryRequirements memoryRequirements;
}
public unsafe struct VkBindVideoSessionMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryBindIndex;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public VkDeviceSize memorySize;
}
public unsafe struct VkVideoSessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoSessionParametersCreateFlagsKHR flags;
	public VkVideoSessionParametersKHR videoSessionParametersTemplate;
	public VkVideoSessionKHR videoSession;
}
public unsafe struct VkVideoSessionParametersUpdateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t updateSequenceCount;
}
public unsafe struct VkVideoBeginCodingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoBeginCodingFlagsKHR flags;
	public VkVideoSessionKHR videoSession;
	public VkVideoSessionParametersKHR videoSessionParameters;
	public uint32_t referenceSlotCount;
	public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}
public unsafe struct VkVideoReferenceSlotInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public int32_t slotIndex;
	public VkVideoPictureResourceInfoKHR* pPictureResource;
}
public unsafe struct VkVideoPictureResourceInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkOffset2D codedOffset;
	public VkExtent2D codedExtent;
	public uint32_t baseArrayLayer;
	public VkImageView imageViewBinding;
}
public unsafe struct VkVideoEndCodingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoEndCodingFlagsKHR flags;
}
public unsafe struct VkVideoCodingControlInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCodingControlFlagsKHR flags;
}
public unsafe struct VkQueueFamilyQueryResultStatusPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 queryResultStatusSupport;
}
public unsafe struct VkQueueFamilyVideoPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoCodecOperationFlagsKHR videoCodecOperations;
}
public unsafe struct VkVideoProfileListInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t profileCount;
	public VkVideoProfileInfoKHR* pProfiles;
}
public unsafe struct VkVideoDecodeInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoDecodeFlagsKHR flags;
	public VkBuffer srcBuffer;
	public VkDeviceSize srcBufferOffset;
	public VkDeviceSize srcBufferRange;
	public VkVideoPictureResourceInfoKHR dstPictureResource;
	public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
	public uint32_t referenceSlotCount;
	public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
}
public unsafe struct VkVideoDecodeCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoDecodeCapabilityFlagsKHR flags;
}
public unsafe struct VkVideoDecodeUsageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkVideoDecodeUsageFlagsKHR videoUsageHints;
}
public unsafe struct VkDedicatedAllocationImageCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dedicatedAllocation;
}
public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dedicatedAllocation;
}
public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}
public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 transformFeedback;
	public VkBool32 geometryStreams;
}
public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxTransformFeedbackStreams;
	public uint32_t maxTransformFeedbackBuffers;
	public VkDeviceSize maxTransformFeedbackBufferSize;
	public uint32_t maxTransformFeedbackStreamDataSize;
	public uint32_t maxTransformFeedbackBufferDataSize;
	public uint32_t maxTransformFeedbackBufferDataStride;
	public VkBool32 transformFeedbackQueries;
	public VkBool32 transformFeedbackStreamsLinesTriangles;
	public VkBool32 transformFeedbackRasterizationStreamSelect;
	public VkBool32 transformFeedbackDraw;
}
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
	public uint32_t rasterizationStream;
}
public unsafe struct VkCuModuleCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public size_t dataSize;
	public void* pData;
}
public unsafe struct VkCuFunctionCreateInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkCuModuleNVX module;
	public char* pName;
}
public unsafe struct VkCuLaunchInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkCuFunctionNVX function;
	public uint32_t gridDimX;
	public uint32_t gridDimY;
	public uint32_t gridDimZ;
	public uint32_t blockDimX;
	public uint32_t blockDimY;
	public uint32_t blockDimZ;
	public uint32_t sharedMemBytes;
	public size_t paramCount;
	public void** pParams;
	public size_t extraCount;
	public void** pExtras;
}
public unsafe struct VkImageViewHandleInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkDescriptorType descriptorType;
	public VkSampler sampler;
}
public unsafe struct VkImageViewAddressPropertiesNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress deviceAddress;
	public VkDeviceSize size;
}
public unsafe struct VkVideoDecodeH264ProfileInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH264ProfileIdc stdProfileIdc;
	public VkVideoDecodeH264PictureLayoutFlagBitsKHR pictureLayout;
}
public unsafe struct VkVideoDecodeH264CapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH264LevelIdc maxLevelIdc;
	public VkOffset2D fieldOffsetGranularity;
}
public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxStdSPSCount;
	public uint32_t maxStdPPSCount;
	public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
}
public unsafe struct VkVideoDecodeH264SessionParametersAddInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t stdSPSCount;
	public StdVideoH264SequenceParameterSet* pStdSPSs;
	public uint32_t stdPPSCount;
	public StdVideoH264PictureParameterSet* pStdPPSs;
}
public unsafe struct VkVideoDecodeH264PictureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH264PictureInfo* pStdPictureInfo;
	public uint32_t sliceCount;
	public uint32_t* pSliceOffsets;
}
public unsafe struct VkVideoDecodeH264DpbSlotInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo;
}
public unsafe struct VkTextureLODGatherFormatPropertiesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supportsTextureGatherLODBiasAMD;
}
public unsafe struct VkShaderResourceUsageAMD
{
	public uint32_t numUsedVgprs;
	public uint32_t numUsedSgprs;
	public uint32_t ldsSizePerLocalWorkGroup;
	public size_t ldsUsageSizeInBytes;
	public size_t scratchMemUsageInBytes;
}
public unsafe struct VkShaderStatisticsInfoAMD
{
	public VkShaderStageFlags shaderStageMask;
	public VkShaderResourceUsageAMD resourceUsage;
	public uint32_t numPhysicalVgprs;
	public uint32_t numPhysicalSgprs;
	public uint32_t numAvailableVgprs;
	public uint32_t numAvailableSgprs;
	public uint32_t computeWorkGroupSize_0;
	public uint32_t computeWorkGroupSize_1;
	public uint32_t computeWorkGroupSize_2;
}
[Obsolete("Use VkRenderingInfo")]
public unsafe struct VkRenderingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public VkRect2D renderArea;
	public uint32_t layerCount;
	public uint32_t viewMask;
	public uint32_t colorAttachmentCount;
	public VkRenderingAttachmentInfo* pColorAttachments;
	public VkRenderingAttachmentInfo* pDepthAttachment;
	public VkRenderingAttachmentInfo* pStencilAttachment;
}
[Obsolete("Use VkRenderingAttachmentInfo")]
public unsafe struct VkRenderingAttachmentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkResolveModeFlagBits resolveMode;
	public VkImageView resolveImageView;
	public VkImageLayout resolveImageLayout;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkClearValue clearValue;
}
[Obsolete("Use VkPipelineRenderingCreateInfo")]
public unsafe struct VkPipelineRenderingCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t viewMask;
	public uint32_t colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
}
[Obsolete("Use VkPhysicalDeviceDynamicRenderingFeatures")]
public unsafe struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dynamicRendering;
}
[Obsolete("Use VkCommandBufferInheritanceRenderingInfo")]
public unsafe struct VkCommandBufferInheritanceRenderingInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderingFlags flags;
	public uint32_t viewMask;
	public uint32_t colorAttachmentCount;
	public VkFormat* pColorAttachmentFormats;
	public VkFormat depthAttachmentFormat;
	public VkFormat stencilAttachmentFormat;
	public VkSampleCountFlagBits rasterizationSamples;
}
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
	public VkExtent2D shadingRateAttachmentTexelSize;
}
public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
	public VkImageLayout imageLayout;
}
public unsafe struct VkAttachmentSampleCountInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t colorAttachmentCount;
	public VkSampleCountFlagBits* pColorAttachmentSamples;
	public VkSampleCountFlagBits depthStencilAttachmentSamples;
}
[Obsolete("Use VkAttachmentSampleCountInfoAMD")]
public unsafe struct VkAttachmentSampleCountInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t colorAttachmentCount;
	public VkSampleCountFlagBits* pColorAttachmentSamples;
	public VkSampleCountFlagBits depthStencilAttachmentSamples;
}
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 perViewAttributes;
	public VkBool32 perViewAttributesPositionXOnly;
}
public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 cornerSampledImage;
}
[Obsolete("Use VkRenderPassMultiviewCreateInfo")]
public unsafe struct VkRenderPassMultiviewCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t subpassCount;
	public uint32_t* pViewMasks;
	public uint32_t dependencyCount;
	public int32_t* pViewOffsets;
	public uint32_t correlationMaskCount;
	public uint32_t* pCorrelationMasks;
}
[Obsolete("Use VkPhysicalDeviceMultiviewFeatures")]
public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiview;
	public VkBool32 multiviewGeometryShader;
	public VkBool32 multiviewTessellationShader;
}
[Obsolete("Use VkPhysicalDeviceMultiviewProperties")]
public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxMultiviewViewCount;
	public uint32_t maxMultiviewInstanceIndex;
}
public unsafe struct VkExternalImageFormatPropertiesNV
{
	public VkImageFormatProperties imageFormatProperties;
	public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
}
public unsafe struct VkExternalMemoryImageCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}
public unsafe struct VkExportMemoryAllocateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleTypes;
}
public unsafe struct VkImportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagsNV handleType;
	public HANDLE handle;
}
public unsafe struct VkExportMemoryWin32HandleInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t acquireCount;
	public VkDeviceMemory* pAcquireSyncs;
	public uint64_t* pAcquireKeys;
	public uint32_t* pAcquireTimeoutMilliseconds;
	public uint32_t releaseCount;
	public VkDeviceMemory* pReleaseSyncs;
	public uint64_t* pReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceFeatures2")]
public unsafe struct VkPhysicalDeviceFeatures2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceFeatures features;
}
[Obsolete("Use VkPhysicalDeviceProperties2")]
public unsafe struct VkPhysicalDeviceProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceProperties properties;
}
[Obsolete("Use VkFormatProperties2")]
public unsafe struct VkFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatProperties formatProperties;
}
[Obsolete("Use VkImageFormatProperties2")]
public unsafe struct VkImageFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageFormatProperties imageFormatProperties;
}
[Obsolete("Use VkPhysicalDeviceImageFormatInfo2")]
public unsafe struct VkPhysicalDeviceImageFormatInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkImageTiling tiling;
	public VkImageUsageFlags usage;
	public VkImageCreateFlags flags;
}
[Obsolete("Use VkQueueFamilyProperties2")]
public unsafe struct VkQueueFamilyProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFamilyProperties queueFamilyProperties;
}
[Obsolete("Use VkPhysicalDeviceMemoryProperties2")]
public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPhysicalDeviceMemoryProperties memoryProperties;
}
[Obsolete("Use VkSparseImageFormatProperties2")]
public unsafe struct VkSparseImageFormatProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageFormatProperties properties;
}
[Obsolete("Use VkPhysicalDeviceSparseImageFormatInfo2")]
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkImageType type;
	public VkSampleCountFlagBits samples;
	public VkImageUsageFlags usage;
	public VkImageTiling tiling;
}
[Obsolete("Use VkMemoryAllocateFlagsInfo")]
public unsafe struct VkMemoryAllocateFlagsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryAllocateFlags flags;
	public uint32_t deviceMask;
}
[Obsolete("Use VkDeviceGroupRenderPassBeginInfo")]
public unsafe struct VkDeviceGroupRenderPassBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
	public uint32_t deviceRenderAreaCount;
	public VkRect2D* pDeviceRenderAreas;
}
[Obsolete("Use VkDeviceGroupCommandBufferBeginInfo")]
public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceMask;
}
[Obsolete("Use VkDeviceGroupSubmitInfo")]
public unsafe struct VkDeviceGroupSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreCount;
	public uint32_t* pWaitSemaphoreDeviceIndices;
	public uint32_t commandBufferCount;
	public uint32_t* pCommandBufferDeviceMasks;
	public uint32_t signalSemaphoreCount;
	public uint32_t* pSignalSemaphoreDeviceIndices;
}
[Obsolete("Use VkDeviceGroupBindSparseInfo")]
public unsafe struct VkDeviceGroupBindSparseInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t resourceDeviceIndex;
	public uint32_t memoryDeviceIndex;
}
[Obsolete("Use VkBindBufferMemoryDeviceGroupInfo")]
public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
}
[Obsolete("Use VkBindImageMemoryDeviceGroupInfo")]
public unsafe struct VkBindImageMemoryDeviceGroupInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
	public uint32_t splitInstanceBindRegionCount;
	public VkRect2D* pSplitInstanceBindRegions;
}
public unsafe struct VkValidationFlagsEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t disabledValidationCheckCount;
	public VkValidationCheckEXT* pDisabledValidationChecks;
}
[Obsolete("Use VkPhysicalDeviceTextureCompressionASTCHDRFeatures")]
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 textureCompressionASTC_HDR;
}
public unsafe struct VkImageViewASTCDecodeModeEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat decodeMode;
}
public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 decodeModeSharedExponent;
}
public unsafe struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineRobustness;
}
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
	public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
}
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
	public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
	public VkPipelineRobustnessImageBehaviorEXT images;
}
[Obsolete("Use VkPhysicalDeviceGroupProperties")]
public unsafe struct VkPhysicalDeviceGroupPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t physicalDeviceCount;
	public VkPhysicalDevice physicalDevices_0;
	public VkPhysicalDevice physicalDevices_1;
	public VkPhysicalDevice physicalDevices_2;
	public VkPhysicalDevice physicalDevices_3;
	public VkPhysicalDevice physicalDevices_4;
	public VkPhysicalDevice physicalDevices_5;
	public VkPhysicalDevice physicalDevices_6;
	public VkPhysicalDevice physicalDevices_7;
	public VkPhysicalDevice physicalDevices_8;
	public VkPhysicalDevice physicalDevices_9;
	public VkPhysicalDevice physicalDevices_10;
	public VkPhysicalDevice physicalDevices_11;
	public VkPhysicalDevice physicalDevices_12;
	public VkPhysicalDevice physicalDevices_13;
	public VkPhysicalDevice physicalDevices_14;
	public VkPhysicalDevice physicalDevices_15;
	public VkPhysicalDevice physicalDevices_16;
	public VkPhysicalDevice physicalDevices_17;
	public VkPhysicalDevice physicalDevices_18;
	public VkPhysicalDevice physicalDevices_19;
	public VkPhysicalDevice physicalDevices_20;
	public VkPhysicalDevice physicalDevices_21;
	public VkPhysicalDevice physicalDevices_22;
	public VkPhysicalDevice physicalDevices_23;
	public VkPhysicalDevice physicalDevices_24;
	public VkPhysicalDevice physicalDevices_25;
	public VkPhysicalDevice physicalDevices_26;
	public VkPhysicalDevice physicalDevices_27;
	public VkPhysicalDevice physicalDevices_28;
	public VkPhysicalDevice physicalDevices_29;
	public VkPhysicalDevice physicalDevices_30;
	public VkPhysicalDevice physicalDevices_31;
	public VkBool32 subsetAllocation;
}
[Obsolete("Use VkDeviceGroupDeviceCreateInfo")]
public unsafe struct VkDeviceGroupDeviceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t physicalDeviceCount;
	public VkPhysicalDevice* pPhysicalDevices;
}
[Obsolete("Use VkExternalMemoryProperties")]
public unsafe struct VkExternalMemoryPropertiesKHR
{
	public VkExternalMemoryFeatureFlags externalMemoryFeatures;
	public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
}
[Obsolete("Use VkPhysicalDeviceExternalImageFormatInfo")]
public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
[Obsolete("Use VkExternalImageFormatProperties")]
public unsafe struct VkExternalImageFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
[Obsolete("Use VkPhysicalDeviceExternalBufferInfo")]
public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateFlags flags;
	public VkBufferUsageFlags usage;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
[Obsolete("Use VkExternalBufferProperties")]
public unsafe struct VkExternalBufferPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryProperties externalMemoryProperties;
}
[Obsolete("Use VkPhysicalDeviceIDProperties")]
public unsafe struct VkPhysicalDeviceIDPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t deviceUUID_0;
	public uint8_t deviceUUID_1;
	public uint8_t deviceUUID_2;
	public uint8_t deviceUUID_3;
	public uint8_t deviceUUID_4;
	public uint8_t deviceUUID_5;
	public uint8_t deviceUUID_6;
	public uint8_t deviceUUID_7;
	public uint8_t deviceUUID_8;
	public uint8_t deviceUUID_9;
	public uint8_t deviceUUID_10;
	public uint8_t deviceUUID_11;
	public uint8_t deviceUUID_12;
	public uint8_t deviceUUID_13;
	public uint8_t deviceUUID_14;
	public uint8_t deviceUUID_15;
	public uint8_t driverUUID_0;
	public uint8_t driverUUID_1;
	public uint8_t driverUUID_2;
	public uint8_t driverUUID_3;
	public uint8_t driverUUID_4;
	public uint8_t driverUUID_5;
	public uint8_t driverUUID_6;
	public uint8_t driverUUID_7;
	public uint8_t driverUUID_8;
	public uint8_t driverUUID_9;
	public uint8_t driverUUID_10;
	public uint8_t driverUUID_11;
	public uint8_t driverUUID_12;
	public uint8_t driverUUID_13;
	public uint8_t driverUUID_14;
	public uint8_t driverUUID_15;
	public uint8_t deviceLUID_0;
	public uint8_t deviceLUID_1;
	public uint8_t deviceLUID_2;
	public uint8_t deviceLUID_3;
	public uint8_t deviceLUID_4;
	public uint8_t deviceLUID_5;
	public uint8_t deviceLUID_6;
	public uint8_t deviceLUID_7;
	public uint32_t deviceNodeMask;
	public VkBool32 deviceLUIDValid;
}
[Obsolete("Use VkExternalMemoryImageCreateInfo")]
public unsafe struct VkExternalMemoryImageCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
[Obsolete("Use VkExternalMemoryBufferCreateInfo")]
public unsafe struct VkExternalMemoryBufferCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
[Obsolete("Use VkExportMemoryAllocateInfo")]
public unsafe struct VkExportMemoryAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlags handleTypes;
}
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkImportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
	public HANDLE handle;
	public LPCWSTR name;
}
public unsafe struct VkExportMemoryWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
	public LPCWSTR name;
}
public unsafe struct VkMemoryGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkMemoryFdPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkImportMemoryFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
	public int fd;
}
public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t acquireCount;
	public VkDeviceMemory* pAcquireSyncs;
	public uint64_t* pAcquireKeys;
	public uint32_t* pAcquireTimeouts;
	public uint32_t releaseCount;
	public VkDeviceMemory* pReleaseSyncs;
	public uint64_t* pReleaseKeys;
}
[Obsolete("Use VkPhysicalDeviceExternalSemaphoreInfo")]
public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
}
[Obsolete("Use VkExternalSemaphoreProperties")]
public unsafe struct VkExternalSemaphorePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
	public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
}
[Obsolete("Use VkExportSemaphoreCreateInfo")]
public unsafe struct VkExportSemaphoreCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalSemaphoreHandleTypeFlags handleTypes;
}
public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
	public HANDLE handle;
	public LPCWSTR name;
}
public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
}
public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
	public LPCWSTR name;
}
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreValuesCount;
	public uint64_t* pWaitSemaphoreValues;
	public uint32_t signalSemaphoreValuesCount;
	public uint64_t* pSignalSemaphoreValues;
}
public unsafe struct VkImportSemaphoreFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkSemaphoreImportFlags flags;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
	public int fd;
}
public unsafe struct VkSemaphoreGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public VkExternalSemaphoreHandleTypeFlagBits handleType;
}
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxPushDescriptors;
}
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkConditionalRenderingFlagsEXT flags;
}
public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 conditionalRendering;
	public VkBool32 inheritedConditionalRendering;
}
public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 conditionalRenderingEnable;
}
[Obsolete("Use VkPhysicalDeviceShaderFloat16Int8Features")]
public unsafe struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
[Obsolete("Use VkPhysicalDeviceShaderFloat16Int8Features")]
public unsafe struct VkPhysicalDeviceFloat16Int8FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderFloat16;
	public VkBool32 shaderInt8;
}
[Obsolete("Use VkPhysicalDevice16BitStorageFeatures")]
public unsafe struct VkPhysicalDevice16BitStorageFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer16BitAccess;
	public VkBool32 uniformAndStorageBuffer16BitAccess;
	public VkBool32 storagePushConstant16;
	public VkBool32 storageInputOutput16;
}
public unsafe struct VkPresentRegionsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public VkPresentRegionKHR* pRegions;
}
public unsafe struct VkPresentRegionKHR
{
	public uint32_t rectangleCount;
	public VkRectLayerKHR* pRectangles;
}
public unsafe struct VkRectLayerKHR
{
	public VkOffset2D offset;
	public VkExtent2D extent;
	public uint32_t layer;
}
[Obsolete("Use VkDescriptorUpdateTemplateEntry")]
public unsafe struct VkDescriptorUpdateTemplateEntryKHR
{
	public uint32_t dstBinding;
	public uint32_t dstArrayElement;
	public uint32_t descriptorCount;
	public VkDescriptorType descriptorType;
	public size_t offset;
	public size_t stride;
}
[Obsolete("Use VkDescriptorUpdateTemplateCreateInfo")]
public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorUpdateTemplateCreateFlags flags;
	public uint32_t descriptorUpdateEntryCount;
	public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
	public VkDescriptorUpdateTemplateType templateType;
	public VkDescriptorSetLayout descriptorSetLayout;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipelineLayout pipelineLayout;
	public uint32_t set;
}
public unsafe struct VkViewportWScalingNV
{
	public float xcoeff;
	public float ycoeff;
}
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 viewportWScalingEnable;
	public uint32_t viewportCount;
	public VkViewportWScalingNV* pViewportWScalings;
}
public unsafe struct VkSurfaceCapabilities2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t minImageCount;
	public uint32_t maxImageCount;
	public VkExtent2D currentExtent;
	public VkExtent2D minImageExtent;
	public VkExtent2D maxImageExtent;
	public uint32_t maxImageArrayLayers;
	public VkSurfaceTransformFlagsKHR supportedTransforms;
	public VkSurfaceTransformFlagBitsKHR currentTransform;
	public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
	public VkImageUsageFlags supportedUsageFlags;
	public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
}
public unsafe struct VkDisplayPowerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPowerStateEXT powerState;
}
public unsafe struct VkDeviceEventInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceEventTypeEXT deviceEvent;
}
public unsafe struct VkDisplayEventInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayEventTypeEXT displayEvent;
}
public unsafe struct VkSwapchainCounterCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceCounterFlagsEXT surfaceCounters;
}
public unsafe struct VkRefreshCycleDurationGOOGLE
{
	public uint64_t refreshDuration;
}
public unsafe struct VkPastPresentationTimingGOOGLE
{
	public uint32_t presentID;
	public uint64_t desiredPresentTime;
	public uint64_t actualPresentTime;
	public uint64_t earliestPresentTime;
	public uint64_t presentMargin;
}
public unsafe struct VkPresentTimesInfoGOOGLE
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public VkPresentTimeGOOGLE* pTimes;
}
public unsafe struct VkPresentTimeGOOGLE
{
	public uint32_t presentID;
	public uint64_t desiredPresentTime;
}
public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 perViewPositionAllComponents;
}
public unsafe struct VkViewportSwizzleNV
{
	public VkViewportCoordinateSwizzleNV x;
	public VkViewportCoordinateSwizzleNV y;
	public VkViewportCoordinateSwizzleNV z;
	public VkViewportCoordinateSwizzleNV w;
}
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
	public uint32_t viewportCount;
	public VkViewportSwizzleNV* pViewportSwizzles;
}
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxDiscardRectangles;
}
public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
	public VkDiscardRectangleModeEXT discardRectangleMode;
	public uint32_t discardRectangleCount;
	public VkRect2D* pDiscardRectangles;
}
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public float primitiveOverestimationSize;
	public float maxExtraPrimitiveOverestimationSize;
	public float extraPrimitiveOverestimationSizeGranularity;
	public VkBool32 primitiveUnderestimation;
	public VkBool32 conservativePointAndLineRasterization;
	public VkBool32 degenerateTrianglesRasterized;
	public VkBool32 degenerateLinesRasterized;
	public VkBool32 fullyCoveredFragmentShaderInputVariable;
	public VkBool32 conservativeRasterizationPostDepthCoverage;
}
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
	public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
	public float extraPrimitiveOverestimationSize;
}
public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 depthClipEnable;
}
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
	public VkBool32 depthClipEnable;
}
public unsafe struct VkHdrMetadataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkXYColorEXT displayPrimaryRed;
	public VkXYColorEXT displayPrimaryGreen;
	public VkXYColorEXT displayPrimaryBlue;
	public VkXYColorEXT whitePoint;
	public float maxLuminance;
	public float minLuminance;
	public float maxContentLightLevel;
	public float maxFrameAverageLightLevel;
}
public unsafe struct VkXYColorEXT
{
	public float x;
	public float y;
}
[Obsolete("Use VkPhysicalDeviceImagelessFramebufferFeatures")]
public unsafe struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imagelessFramebuffer;
}
[Obsolete("Use VkFramebufferAttachmentsCreateInfo")]
public unsafe struct VkFramebufferAttachmentsCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentImageInfoCount;
	public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}
[Obsolete("Use VkFramebufferAttachmentImageInfo")]
public unsafe struct VkFramebufferAttachmentImageInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateFlags flags;
	public VkImageUsageFlags usage;
	public uint32_t width;
	public uint32_t height;
	public uint32_t layerCount;
	public uint32_t viewFormatCount;
	public VkFormat* pViewFormats;
}
[Obsolete("Use VkRenderPassAttachmentBeginInfo")]
public unsafe struct VkRenderPassAttachmentBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentCount;
	public VkImageView* pAttachments;
}
[Obsolete("Use VkRenderPassCreateInfo2")]
public unsafe struct VkRenderPassCreateInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreateFlags flags;
	public uint32_t attachmentCount;
	public VkAttachmentDescription2* pAttachments;
	public uint32_t subpassCount;
	public VkSubpassDescription2* pSubpasses;
	public uint32_t dependencyCount;
	public VkSubpassDependency2* pDependencies;
	public uint32_t correlatedViewMaskCount;
	public uint32_t* pCorrelatedViewMasks;
}
[Obsolete("Use VkAttachmentDescription2")]
public unsafe struct VkAttachmentDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentDescriptionFlags flags;
	public VkFormat format;
	public VkSampleCountFlagBits samples;
	public VkAttachmentLoadOp loadOp;
	public VkAttachmentStoreOp storeOp;
	public VkAttachmentLoadOp stencilLoadOp;
	public VkAttachmentStoreOp stencilStoreOp;
	public VkImageLayout initialLayout;
	public VkImageLayout finalLayout;
}
[Obsolete("Use VkAttachmentReference2")]
public unsafe struct VkAttachmentReference2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachment;
	public VkImageLayout layout;
	public VkImageAspectFlags aspectMask;
}
[Obsolete("Use VkSubpassDescription2")]
public unsafe struct VkSubpassDescription2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassDescriptionFlags flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint32_t viewMask;
	public uint32_t inputAttachmentCount;
	public VkAttachmentReference2* pInputAttachments;
	public uint32_t colorAttachmentCount;
	public VkAttachmentReference2* pColorAttachments;
	public VkAttachmentReference2* pResolveAttachments;
	public VkAttachmentReference2* pDepthStencilAttachment;
	public uint32_t preserveAttachmentCount;
	public uint32_t* pPreserveAttachments;
}
[Obsolete("Use VkSubpassDependency2")]
public unsafe struct VkSubpassDependency2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t srcSubpass;
	public uint32_t dstSubpass;
	public VkPipelineStageFlags srcStageMask;
	public VkPipelineStageFlags dstStageMask;
	public VkAccessFlags srcAccessMask;
	public VkAccessFlags dstAccessMask;
	public VkDependencyFlags dependencyFlags;
	public int32_t viewOffset;
}
[Obsolete("Use VkSubpassBeginInfo")]
public unsafe struct VkSubpassBeginInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubpassContents contents;
}
[Obsolete("Use VkSubpassEndInfo")]
public unsafe struct VkSubpassEndInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
}
public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags sharedPresentSupportedUsageFlags;
}
[Obsolete("Use VkPhysicalDeviceExternalFenceInfo")]
public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlagBits handleType;
}
[Obsolete("Use VkExternalFenceProperties")]
public unsafe struct VkExternalFencePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
	public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
	public VkExternalFenceFeatureFlags externalFenceFeatures;
}
[Obsolete("Use VkExportFenceCreateInfo")]
public unsafe struct VkExportFenceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalFenceHandleTypeFlags handleTypes;
}
public unsafe struct VkImportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlagBits handleType;
	public HANDLE handle;
	public LPCWSTR name;
}
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlagBits handleType;
}
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public SECURITY_ATTRIBUTES* pAttributes;
	public DWORD dwAccess;
	public LPCWSTR name;
}
public unsafe struct VkImportFenceFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkFenceImportFlags flags;
	public VkExternalFenceHandleTypeFlagBits handleType;
	public int fd;
}
public unsafe struct VkFenceGetFdInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFence fence;
	public VkExternalFenceHandleTypeFlagBits handleType;
}
public unsafe struct VkPerformanceCounterKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceCounterUnitKHR unit;
	public VkPerformanceCounterScopeKHR scope;
	public VkPerformanceCounterStorageKHR storage;
	public uint8_t uuid_0;
	public uint8_t uuid_1;
	public uint8_t uuid_2;
	public uint8_t uuid_3;
	public uint8_t uuid_4;
	public uint8_t uuid_5;
	public uint8_t uuid_6;
	public uint8_t uuid_7;
	public uint8_t uuid_8;
	public uint8_t uuid_9;
	public uint8_t uuid_10;
	public uint8_t uuid_11;
	public uint8_t uuid_12;
	public uint8_t uuid_13;
	public uint8_t uuid_14;
	public uint8_t uuid_15;
}
public unsafe struct VkPerformanceCounterDescriptionKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceCounterDescriptionFlagsKHR flags;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char category[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
}
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t queueFamilyIndex;
	public uint32_t counterIndexCount;
	public uint32_t* pCounterIndices;
}
public unsafe struct VkAcquireProfilingLockInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAcquireProfilingLockFlagsKHR flags;
	public uint64_t timeout;
}
public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 performanceCounterQueryPools;
	public VkBool32 performanceCounterMultipleQueryPools;
}
public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 allowCommandBufferQueryCopies;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceCounterResultKHR
{
	[FieldOffset(0)]
	public int32_t int32;
	[FieldOffset(0)]
	public int64_t int64;
	[FieldOffset(0)]
	public uint32_t uint32;
	[FieldOffset(0)]
	public uint64_t uint64;
	[FieldOffset(0)]
	public float float32;
	[FieldOffset(0)]
	public double float64;
}
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t counterPassIndex;
}
[Obsolete("Use VkPhysicalDevicePointClippingProperties")]
public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPointClippingBehavior pointClippingBehavior;
}
[Obsolete("Use VkRenderPassInputAttachmentAspectCreateInfo")]
public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t aspectReferenceCount;
	public VkInputAttachmentAspectReference* pAspectReferences;
}
[Obsolete("Use VkInputAttachmentAspectReference")]
public unsafe struct VkInputAttachmentAspectReferenceKHR
{
	public uint32_t subpass;
	public uint32_t inputAttachmentIndex;
	public VkImageAspectFlags aspectMask;
}
[Obsolete("Use VkImageViewUsageCreateInfo")]
public unsafe struct VkImageViewUsageCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags usage;
}
[Obsolete("Use VkPipelineTessellationDomainOriginStateCreateInfo")]
public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkTessellationDomainOrigin domainOrigin;
}
public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceKHR surface;
}
public unsafe struct VkSurfaceCapabilities2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceCapabilitiesKHR surfaceCapabilities;
}
public unsafe struct VkSurfaceFormat2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceFormatKHR surfaceFormat;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
[Obsolete("Use VkPhysicalDeviceVariablePointersFeatures")]
public unsafe struct VkPhysicalDeviceVariablePointersFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 variablePointersStorageBuffer;
	public VkBool32 variablePointers;
}
public unsafe struct VkDisplayProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPropertiesKHR displayProperties;
}
public unsafe struct VkDisplayPlaneProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPlanePropertiesKHR displayPlaneProperties;
}
public unsafe struct VkDisplayModeProperties2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayModePropertiesKHR displayModeProperties;
}
public unsafe struct VkDisplayPlaneInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayModeKHR mode;
	public uint32_t planeIndex;
}
public unsafe struct VkDisplayPlaneCapabilities2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDisplayPlaneCapabilitiesKHR capabilities;
}
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
	public VkStructureType sType;
	public void* pNext;
	public VkMacOSSurfaceCreateFlagsMVK flags;
	public void* pView;
}
[Obsolete("Use VkMemoryDedicatedRequirements")]
public unsafe struct VkMemoryDedicatedRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 prefersDedicatedAllocation;
	public VkBool32 requiresDedicatedAllocation;
}
[Obsolete("Use VkMemoryDedicatedAllocateInfo")]
public unsafe struct VkMemoryDedicatedAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkBuffer buffer;
}
public unsafe struct VkDebugUtilsObjectNameInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectType objectType;
	public uint64_t objectHandle;
	public char* pObjectName;
}
public unsafe struct VkDebugUtilsObjectTagInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkObjectType objectType;
	public uint64_t objectHandle;
	public uint64_t tagName;
	public size_t tagSize;
	public void* pTag;
}
public unsafe struct VkDebugUtilsLabelEXT
{
	public VkStructureType sType;
	public void* pNext;
	public char* pLabelName;
	public fixed float color[];
}
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugUtilsMessengerCreateFlagsEXT flags;
	public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
	public VkDebugUtilsMessageTypeFlagsEXT messageType;
	public PFN_vkDebugUtilsMessengerCallbackEXT pfnUserCallback;
	public void* pUserData;
}
public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
	public char* pMessageIdName;
	public int32_t messageIdNumber;
	public char* pMessage;
	public uint32_t queueLabelCount;
	public VkDebugUtilsLabelEXT* pQueueLabels;
	public uint32_t cmdBufLabelCount;
	public VkDebugUtilsLabelEXT* pCmdBufLabels;
	public uint32_t objectCount;
	public VkDebugUtilsObjectNameInfoEXT* pObjects;
}
public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize allocationSize;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t androidHardwareBufferUsage;
}
public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public uint64_t externalFormat;
	public VkFormatFeatureFlags formatFeatures;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}
public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public AHardwareBuffer* buffer;
}
public unsafe struct VkExternalFormatANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t externalFormat;
}
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public uint64_t externalFormat;
	public VkFormatFeatureFlags2 formatFeatures;
	public VkComponentMapping samplerYcbcrConversionComponents;
	public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
	public VkSamplerYcbcrRange suggestedYcbcrRange;
	public VkChromaLocation suggestedXChromaOffset;
	public VkChromaLocation suggestedYChromaOffset;
}
[Obsolete("Use VkSamplerReductionModeCreateInfo")]
public unsafe struct VkSamplerReductionModeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerReductionMode reductionMode;
}
[Obsolete("Use VkPhysicalDeviceSamplerFilterMinmaxProperties")]
public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterMinmaxSingleComponentFormats;
	public VkBool32 filterMinmaxImageComponentMapping;
}
[Obsolete("Use VkPhysicalDeviceInlineUniformBlockFeatures")]
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inlineUniformBlock;
	public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}
[Obsolete("Use VkPhysicalDeviceInlineUniformBlockProperties")]
public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxInlineUniformBlockSize;
	public uint32_t maxPerStageDescriptorInlineUniformBlocks;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
	public uint32_t maxDescriptorSetInlineUniformBlocks;
	public uint32_t maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
}
[Obsolete("Use VkWriteDescriptorSetInlineUniformBlock")]
public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t dataSize;
	public void* pData;
}
[Obsolete("Use VkDescriptorPoolInlineUniformBlockCreateInfo")]
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxInlineUniformBlockBindings;
}
public unsafe struct VkSampleLocationsInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlagBits sampleLocationsPerPixel;
	public VkExtent2D sampleLocationGridSize;
	public uint32_t sampleLocationsCount;
	public VkSampleLocationEXT* pSampleLocations;
}
public unsafe struct VkSampleLocationEXT
{
	public float x;
	public float y;
}
public unsafe struct VkMultisamplePropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D maxSampleLocationGridSize;
}
public unsafe struct VkAttachmentSampleLocationsEXT
{
	public uint32_t attachmentIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkSubpassSampleLocationsEXT
{
	public uint32_t subpassIndex;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentInitialSampleLocationsCount;
	public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
	public uint32_t postSubpassSampleLocationsCount;
	public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
}
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 sampleLocationsEnable;
	public VkSampleLocationsInfoEXT sampleLocationsInfo;
}
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlags sampleLocationSampleCounts;
	public VkExtent2D maxSampleLocationGridSize;
	public fixed float sampleLocationCoordinateRange[];
	public uint32_t sampleLocationSubPixelBits;
	public VkBool32 variableSampleLocations;
}
[Obsolete("Use VkBufferMemoryRequirementsInfo2")]
public unsafe struct VkBufferMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
[Obsolete("Use VkImageMemoryRequirementsInfo2")]
public unsafe struct VkImageMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
[Obsolete("Use VkImageSparseMemoryRequirementsInfo2")]
public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
[Obsolete("Use VkMemoryRequirements2")]
public unsafe struct VkMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryRequirements memoryRequirements;
}
[Obsolete("Use VkSparseImageMemoryRequirements2")]
public unsafe struct VkSparseImageMemoryRequirements2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSparseImageMemoryRequirements memoryRequirements;
}
[Obsolete("Use VkImageFormatListCreateInfo")]
public unsafe struct VkImageFormatListCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t viewFormatCount;
	public VkFormat* pViewFormats;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 advancedBlendCoherentOperations;
}
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t advancedBlendMaxColorAttachments;
	public VkBool32 advancedBlendIndependentBlend;
	public VkBool32 advancedBlendNonPremultipliedSrcColor;
	public VkBool32 advancedBlendNonPremultipliedDstColor;
	public VkBool32 advancedBlendCorrelatedOverlap;
	public VkBool32 advancedBlendAllOperations;
}
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 srcPremultiplied;
	public VkBool32 dstPremultiplied;
	public VkBlendOverlapEXT blendOverlap;
}
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageToColorStateCreateFlagsNV flags;
	public VkBool32 coverageToColorEnable;
	public uint32_t coverageToColorLocation;
}
public unsafe struct VkAccelerationStructureCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureCreateFlagsKHR createFlags;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
	public VkAccelerationStructureTypeKHR type;
	public VkDeviceAddress deviceAddress;
}
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureTypeKHR type;
	public VkBuildAccelerationStructureFlagsKHR flags;
	public VkBuildAccelerationStructureModeKHR mode;
	public VkAccelerationStructureKHR srcAccelerationStructure;
	public VkAccelerationStructureKHR dstAccelerationStructure;
	public uint32_t geometryCount;
	public VkAccelerationStructureGeometryKHR* pGeometries;
	public VkAccelerationStructureGeometryKHR** ppGeometries;
	public VkDeviceOrHostAddressKHR scratchData;
}
public unsafe struct VkAccelerationStructureGeometryKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkGeometryTypeKHR geometryType;
	public VkAccelerationStructureGeometryDataKHR geometry;
	public VkGeometryFlagsKHR flags;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureGeometryDataKHR
{
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
	[FieldOffset(0)]
	public VkAccelerationStructureGeometryInstancesDataKHR instances;
}
public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat vertexFormat;
	public VkDeviceOrHostAddressConstKHR vertexData;
	public VkDeviceSize vertexStride;
	public uint32_t maxVertex;
	public VkIndexType indexType;
	public VkDeviceOrHostAddressConstKHR indexData;
	public VkDeviceOrHostAddressConstKHR transformData;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressConstKHR
{
	[FieldOffset(0)]
	public VkDeviceAddress deviceAddress;
	[FieldOffset(0)]
	public void* hostAddress;
}
public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR data;
	public VkDeviceSize stride;
}
public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 arrayOfPointers;
	public VkDeviceOrHostAddressConstKHR data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDeviceOrHostAddressKHR
{
	[FieldOffset(0)]
	public VkDeviceAddress deviceAddress;
	[FieldOffset(0)]
	public void* hostAddress;
}
public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
{
	public uint32_t primitiveCount;
	public uint32_t primitiveOffset;
	public uint32_t firstVertex;
	public uint32_t transformOffset;
}
public unsafe struct VkCopyAccelerationStructureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR src;
	public VkAccelerationStructureKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}
public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR src;
	public VkDeviceOrHostAddressKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}
public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR src;
	public VkAccelerationStructureKHR dst;
	public VkCopyAccelerationStructureModeKHR mode;
}
public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR accelerationStructure;
}
public unsafe struct VkAccelerationStructureVersionInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t* pVersionData;
}
public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize accelerationStructureSize;
	public VkDeviceSize updateScratchSize;
	public VkDeviceSize buildScratchSize;
}
public unsafe struct VkAabbPositionsKHR
{
	public float minX;
	public float minY;
	public float minZ;
	public float maxX;
	public float maxY;
	public float maxZ;
}
public unsafe struct VkTransformMatrixKHR
{
	public fixed float matrix[12];
}
public unsafe struct VkAccelerationStructureInstanceKHR
{
	public VkTransformMatrixKHR transform;
	public uint32_t instanceCustomIndex;
	public uint32_t mask;
	public uint32_t instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public uint64_t accelerationStructureReference;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t accelerationStructureCount;
	public VkAccelerationStructureKHR* pAccelerationStructures;
}
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 accelerationStructure;
	public VkBool32 accelerationStructureCaptureReplay;
	public VkBool32 accelerationStructureIndirectBuild;
	public VkBool32 accelerationStructureHostCommands;
	public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
}
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t maxGeometryCount;
	public uint64_t maxInstanceCount;
	public uint64_t maxPrimitiveCount;
	public uint32_t maxPerStageDescriptorAccelerationStructures;
	public uint32_t maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
	public uint32_t maxDescriptorSetAccelerationStructures;
	public uint32_t maxDescriptorSetUpdateAfterBindAccelerationStructures;
	public uint32_t minAccelerationStructureScratchOffsetAlignment;
}
public unsafe struct VkStridedDeviceAddressRegionKHR
{
	public VkDeviceAddress deviceAddress;
	public VkDeviceSize stride;
	public VkDeviceSize size;
}
public unsafe struct VkRayTracingPipelineCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint32_t stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public uint32_t groupCount;
	public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
	public uint32_t maxPipelineRayRecursionDepth;
	public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
	public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
	public VkPipelineDynamicStateCreateInfo* pDynamicState;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int32_t basePipelineIndex;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingShaderGroupTypeKHR type;
	public uint32_t generalShader;
	public uint32_t closestHitShader;
	public uint32_t anyHitShader;
	public uint32_t intersectionShader;
	public void* pShaderGroupCaptureReplayHandle;
}
public unsafe struct VkPipelineLibraryCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t libraryCount;
	public VkPipeline* pLibraries;
}
public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxPipelineRayPayloadSize;
	public uint32_t maxPipelineRayHitAttributeSize;
}
public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingPipeline;
	public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
	public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
	public VkBool32 rayTracingPipelineTraceRaysIndirect;
	public VkBool32 rayTraversalPrimitiveCulling;
}
public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t shaderGroupHandleSize;
	public uint32_t maxRayRecursionDepth;
	public uint32_t maxShaderGroupStride;
	public uint32_t shaderGroupBaseAlignment;
	public uint32_t shaderGroupHandleCaptureReplaySize;
	public uint32_t maxRayDispatchInvocationCount;
	public uint32_t shaderGroupHandleAlignment;
	public uint32_t maxRayHitAttributeSize;
}
public unsafe struct VkTraceRaysIndirectCommandKHR
{
	public uint32_t width;
	public uint32_t height;
	public uint32_t depth;
}
public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayQuery;
}
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageModulationStateCreateFlagsNV flags;
	public VkCoverageModulationModeNV coverageModulationMode;
	public VkBool32 coverageModulationTableEnable;
	public uint32_t coverageModulationTableCount;
	public float* pCoverageModulationTable;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t shaderSMCount;
	public uint32_t shaderWarpsPerSM;
}
public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSMBuiltins;
}
[Obsolete("Use VkSamplerYcbcrConversionCreateInfo")]
public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
	public VkSamplerYcbcrModelConversion ycbcrModel;
	public VkSamplerYcbcrRange ycbcrRange;
	public VkComponentMapping components;
	public VkChromaLocation xChromaOffset;
	public VkChromaLocation yChromaOffset;
	public VkFilter chromaFilter;
	public VkBool32 forceExplicitReconstruction;
}
[Obsolete("Use VkSamplerYcbcrConversionInfo")]
public unsafe struct VkSamplerYcbcrConversionInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSamplerYcbcrConversion conversion;
}
[Obsolete("Use VkBindImagePlaneMemoryInfo")]
public unsafe struct VkBindImagePlaneMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
}
[Obsolete("Use VkImagePlaneMemoryRequirementsInfo")]
public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageAspectFlagBits planeAspect;
}
[Obsolete("Use VkPhysicalDeviceSamplerYcbcrConversionFeatures")]
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 samplerYcbcrConversion;
}
[Obsolete("Use VkSamplerYcbcrConversionImageFormatProperties")]
public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t combinedImageSamplerDescriptorCount;
}
[Obsolete("Use VkBindBufferMemoryInfo")]
public unsafe struct VkBindBufferMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
[Obsolete("Use VkBindImageMemoryInfo")]
public unsafe struct VkBindImageMemoryInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
}
public unsafe struct VkImageDrmFormatModifierPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t drmFormatModifier;
}
public unsafe struct VkDrmFormatModifierPropertiesListEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t drmFormatModifierCount;
	public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
	public uint64_t drmFormatModifier;
	public uint32_t drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
}
public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t drmFormatModifier;
	public VkSharingMode sharingMode;
	public uint32_t queueFamilyIndexCount;
	public uint32_t* pQueueFamilyIndices;
}
public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t drmFormatModifierCount;
	public uint64_t* pDrmFormatModifiers;
}
public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t drmFormatModifier;
	public uint32_t drmFormatModifierPlaneCount;
	public VkSubresourceLayout* pPlaneLayouts;
}
public unsafe struct VkDrmFormatModifierPropertiesList2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t drmFormatModifierCount;
	public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
}
public unsafe struct VkDrmFormatModifierProperties2EXT
{
	public uint64_t drmFormatModifier;
	public uint32_t drmFormatModifierPlaneCount;
	public VkFormatFeatureFlags2 drmFormatModifierTilingFeatures;
}
public unsafe struct VkValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkValidationCacheCreateFlagsEXT flags;
	public size_t initialDataSize;
	public void* pInitialData;
}
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkValidationCacheEXT validationCache;
}
[Obsolete("Use VkDescriptorSetLayoutBindingFlagsCreateInfo")]
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t bindingCount;
	public VkDescriptorBindingFlags* pBindingFlags;
}
[Obsolete("Use VkPhysicalDeviceDescriptorIndexingFeatures")]
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
	public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
	public VkBool32 shaderSampledImageArrayNonUniformIndexing;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageImageArrayNonUniformIndexing;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
	public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
	public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
	public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
	public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
	public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
	public VkBool32 descriptorBindingUpdateUnusedWhilePending;
	public VkBool32 descriptorBindingPartiallyBound;
	public VkBool32 descriptorBindingVariableDescriptorCount;
	public VkBool32 runtimeDescriptorArray;
}
[Obsolete("Use VkPhysicalDeviceDescriptorIndexingProperties")]
public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxUpdateAfterBindDescriptorsInAllPools;
	public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
	public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
	public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
	public VkBool32 robustBufferAccessUpdateAfterBind;
	public VkBool32 quadDivergentImplicitLod;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSamplers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindUniformBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageBuffers;
	public uint32_t maxPerStageDescriptorUpdateAfterBindSampledImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindStorageImages;
	public uint32_t maxPerStageDescriptorUpdateAfterBindInputAttachments;
	public uint32_t maxPerStageUpdateAfterBindResources;
	public uint32_t maxDescriptorSetUpdateAfterBindSamplers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffers;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
	public uint32_t maxDescriptorSetUpdateAfterBindSampledImages;
	public uint32_t maxDescriptorSetUpdateAfterBindStorageImages;
	public uint32_t maxDescriptorSetUpdateAfterBindInputAttachments;
}
[Obsolete("Use VkDescriptorSetVariableDescriptorCountAllocateInfo")]
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t descriptorSetCount;
	public uint32_t* pDescriptorCounts;
}
[Obsolete("Use VkDescriptorSetVariableDescriptorCountLayoutSupport")]
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxVariableDescriptorCount;
}
public unsafe struct VkShadingRatePaletteNV
{
	public uint32_t shadingRatePaletteEntryCount;
	public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
}
public unsafe struct VkCoarseSampleOrderCustomNV
{
	public VkShadingRatePaletteEntryNV shadingRate;
	public uint32_t sampleCount;
	public uint32_t sampleLocationCount;
	public VkCoarseSampleLocationNV* pSampleLocations;
}
public unsafe struct VkCoarseSampleLocationNV
{
	public uint32_t pixelX;
	public uint32_t pixelY;
	public uint32_t sample;
}
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shadingRateImageEnable;
	public uint32_t viewportCount;
	public VkShadingRatePaletteNV* pShadingRatePalettes;
}
public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shadingRateImage;
	public VkBool32 shadingRateCoarseSampleOrder;
}
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D shadingRateTexelSize;
	public uint32_t shadingRatePaletteSize;
	public uint32_t shadingRateMaxCoarseSamples;
}
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkCoarseSampleOrderTypeNV sampleOrderType;
	public uint32_t customSampleOrderCount;
	public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
}
public unsafe struct VkAccelerationStructureCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize compactedSize;
	public VkAccelerationStructureInfoNV info;
}
public unsafe struct VkAccelerationStructureInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureTypeNV type;
	public VkBuildAccelerationStructureFlagsNV flags;
	public uint32_t instanceCount;
	public uint32_t geometryCount;
	public VkGeometryNV* pGeometries;
}
public unsafe struct VkGeometryNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkGeometryTypeKHR geometryType;
	public VkGeometryDataNV geometry;
	public VkGeometryFlagsKHR flags;
}
public unsafe struct VkGeometryDataNV
{
	public VkGeometryTrianglesNV triangles;
	public VkGeometryAABBNV aabbs;
}
public unsafe struct VkGeometryTrianglesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer vertexData;
	public VkDeviceSize vertexOffset;
	public uint32_t vertexCount;
	public VkDeviceSize vertexStride;
	public VkFormat vertexFormat;
	public VkBuffer indexData;
	public VkDeviceSize indexOffset;
	public uint32_t indexCount;
	public VkIndexType indexType;
	public VkBuffer transformData;
	public VkDeviceSize transformOffset;
}
public unsafe struct VkGeometryAABBNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer aabbData;
	public uint32_t numAABBs;
	public uint32_t stride;
	public VkDeviceSize offset;
}
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureMemoryRequirementsTypeNV type;
	public VkAccelerationStructureNV accelerationStructure;
}
public unsafe struct VkBindAccelerationStructureMemoryInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureNV accelerationStructure;
	public VkDeviceMemory memory;
	public VkDeviceSize memoryOffset;
	public uint32_t deviceIndexCount;
	public uint32_t* pDeviceIndices;
}
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreateFlags flags;
	public uint32_t stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public uint32_t groupCount;
	public VkRayTracingShaderGroupCreateInfoNV* pGroups;
	public uint32_t maxRecursionDepth;
	public VkPipelineLayout layout;
	public VkPipeline basePipelineHandle;
	public int32_t basePipelineIndex;
}
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingShaderGroupTypeKHR type;
	public uint32_t generalShader;
	public uint32_t closestHitShader;
	public uint32_t anyHitShader;
	public uint32_t intersectionShader;
}
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t accelerationStructureCount;
	public VkAccelerationStructureNV* pAccelerationStructures;
}
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t shaderGroupHandleSize;
	public uint32_t maxRecursionDepth;
	public uint32_t maxShaderGroupStride;
	public uint32_t shaderGroupBaseAlignment;
	public uint64_t maxGeometryCount;
	public uint64_t maxInstanceCount;
	public uint64_t maxTriangleCount;
	public uint32_t maxDescriptorSetAccelerationStructures;
}
[Obsolete("Use VkTransformMatrixKHR")]
public unsafe struct VkTransformMatrixNV
{
	public fixed float matrix[12];
}
[Obsolete("Use VkAabbPositionsKHR")]
public unsafe struct VkAabbPositionsNV
{
	public float minX;
	public float minY;
	public float minZ;
	public float maxX;
	public float maxY;
	public float maxZ;
}
[Obsolete("Use VkAccelerationStructureInstanceKHR")]
public unsafe struct VkAccelerationStructureInstanceNV
{
	public VkTransformMatrixKHR transform;
	public uint32_t instanceCustomIndex;
	public uint32_t mask;
	public uint32_t instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public uint64_t accelerationStructureReference;
}
public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 representativeFragmentTest;
}
public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 representativeFragmentTestEnable;
}
[Obsolete("Use VkPhysicalDeviceMaintenance3Properties")]
public unsafe struct VkPhysicalDeviceMaintenance3PropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxPerSetDescriptors;
	public VkDeviceSize maxMemoryAllocationSize;
}
[Obsolete("Use VkDescriptorSetLayoutSupport")]
public unsafe struct VkDescriptorSetLayoutSupportKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supported;
}
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageViewType imageViewType;
}
public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 filterCubic;
	public VkBool32 filterCubicMinmax;
}
[Obsolete("Use VkDeviceQueueGlobalPriorityCreateInfoKHR")]
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueGlobalPriorityKHR globalPriority;
}
[Obsolete("Use VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures")]
public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupExtendedTypes;
}
[Obsolete("Use VkPhysicalDevice8BitStorageFeatures")]
public unsafe struct VkPhysicalDevice8BitStorageFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 storageBuffer8BitAccess;
	public VkBool32 uniformAndStorageBuffer8BitAccess;
	public VkBool32 storagePushConstant8;
}
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t memoryTypeBits;
}
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExternalMemoryHandleTypeFlagBits handleType;
	public void* pHostPointer;
}
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize minImportedHostPointerAlignment;
}
[Obsolete("Use VkPhysicalDeviceShaderAtomicInt64Features")]
public unsafe struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferInt64Atomics;
	public VkBool32 shaderSharedInt64Atomics;
}
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupClock;
	public VkBool32 shaderDeviceClock;
}
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
}
public unsafe struct VkCalibratedTimestampInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkTimeDomainEXT timeDomain;
}
public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t shaderEngineCount;
	public uint32_t shaderArraysPerEngineCount;
	public uint32_t computeUnitsPerShaderArray;
	public uint32_t simdPerComputeUnit;
	public uint32_t wavefrontsPerSimd;
	public uint32_t wavefrontSize;
	public uint32_t sgprsPerSimd;
	public uint32_t minSgprAllocation;
	public uint32_t maxSgprAllocation;
	public uint32_t sgprAllocationGranularity;
	public uint32_t vgprsPerSimd;
	public uint32_t minVgprAllocation;
	public uint32_t maxVgprAllocation;
	public uint32_t vgprAllocationGranularity;
}
public unsafe struct VkVideoDecodeH265ProfileInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH265ProfileIdc stdProfileIdc;
}
public unsafe struct VkVideoDecodeH265CapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoH265LevelIdc maxLevelIdc;
}
public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxStdVPSCount;
	public uint32_t maxStdSPSCount;
	public uint32_t maxStdPPSCount;
	public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
}
public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t stdVPSCount;
	public StdVideoH265VideoParameterSet* pStdVPSs;
	public uint32_t stdSPSCount;
	public StdVideoH265SequenceParameterSet* pStdSPSs;
	public uint32_t stdPPSCount;
	public StdVideoH265PictureParameterSet* pStdPPSs;
}
public unsafe struct VkVideoDecodeH265PictureInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH265PictureInfo* pStdPictureInfo;
	public uint32_t sliceSegmentCount;
	public uint32_t* pSliceSegmentOffsets;
}
public unsafe struct VkVideoDecodeH265DpbSlotInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
}
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueGlobalPriorityKHR globalPriority;
}
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 globalPriorityQuery;
}
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t priorityCount;
	public VkQueueGlobalPriorityKHR priorities_0;
	public VkQueueGlobalPriorityKHR priorities_1;
	public VkQueueGlobalPriorityKHR priorities_2;
	public VkQueueGlobalPriorityKHR priorities_3;
	public VkQueueGlobalPriorityKHR priorities_4;
	public VkQueueGlobalPriorityKHR priorities_5;
	public VkQueueGlobalPriorityKHR priorities_6;
	public VkQueueGlobalPriorityKHR priorities_7;
	public VkQueueGlobalPriorityKHR priorities_8;
	public VkQueueGlobalPriorityKHR priorities_9;
	public VkQueueGlobalPriorityKHR priorities_10;
	public VkQueueGlobalPriorityKHR priorities_11;
	public VkQueueGlobalPriorityKHR priorities_12;
	public VkQueueGlobalPriorityKHR priorities_13;
	public VkQueueGlobalPriorityKHR priorities_14;
	public VkQueueGlobalPriorityKHR priorities_15;
}
public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxVertexAttribDivisor;
}
public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
{
	public uint32_t binding;
	public uint32_t divisor;
}
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t vertexBindingDivisorCount;
	public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
}
public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vertexAttributeInstanceRateDivisor;
	public VkBool32 vertexAttributeInstanceRateZeroDivisor;
}
[Obsolete("Use VkPipelineCreationFeedbackCreateInfo")]
public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCreationFeedback* pPipelineCreationFeedback;
	public uint32_t pipelineStageCreationFeedbackCount;
	public VkPipelineCreationFeedback** pPipelineStageCreationFeedbacks;
}
[Obsolete("Use VkPipelineCreationFeedback")]
public unsafe struct VkPipelineCreationFeedbackEXT
{
	public VkPipelineCreationFeedbackFlags flags;
	public uint64_t duration;
}
[Obsolete("Use VkConformanceVersion")]
public unsafe struct VkConformanceVersionKHR
{
	public uint8_t major;
	public uint8_t minor;
	public uint8_t subminor;
	public uint8_t patch;
}
[Obsolete("Use VkPhysicalDeviceDriverProperties")]
public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDriverId driverID;
	public fixed char driverName[VK.VK_MAX_DRIVER_NAME_SIZE];
	public fixed char driverInfo[VK.VK_MAX_DRIVER_INFO_SIZE];
	public VkConformanceVersion conformanceVersion;
}
[Obsolete("Use VkPhysicalDeviceFloatControlsProperties")]
public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderFloatControlsIndependence denormBehaviorIndependence;
	public VkShaderFloatControlsIndependence roundingModeIndependence;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
	public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
	public VkBool32 shaderDenormPreserveFloat16;
	public VkBool32 shaderDenormPreserveFloat32;
	public VkBool32 shaderDenormPreserveFloat64;
	public VkBool32 shaderDenormFlushToZeroFloat16;
	public VkBool32 shaderDenormFlushToZeroFloat32;
	public VkBool32 shaderDenormFlushToZeroFloat64;
	public VkBool32 shaderRoundingModeRTEFloat16;
	public VkBool32 shaderRoundingModeRTEFloat32;
	public VkBool32 shaderRoundingModeRTEFloat64;
	public VkBool32 shaderRoundingModeRTZFloat16;
	public VkBool32 shaderRoundingModeRTZFloat32;
	public VkBool32 shaderRoundingModeRTZFloat64;
}
[Obsolete("Use VkSubpassDescriptionDepthStencilResolve")]
public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlagBits depthResolveMode;
	public VkResolveModeFlagBits stencilResolveMode;
	public VkAttachmentReference2* pDepthStencilResolveAttachment;
}
[Obsolete("Use VkPhysicalDeviceDepthStencilResolveProperties")]
public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkResolveModeFlags supportedDepthResolveModes;
	public VkResolveModeFlags supportedStencilResolveModes;
	public VkBool32 independentResolveNone;
	public VkBool32 independentResolve;
}
public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 computeDerivativeGroupQuads;
	public VkBool32 computeDerivativeGroupLinear;
}
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 taskShader;
	public VkBool32 meshShader;
}
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxDrawMeshTasksCount;
	public uint32_t maxTaskWorkGroupInvocations;
	public uint32_t maxTaskWorkGroupSize_0;
	public uint32_t maxTaskWorkGroupSize_1;
	public uint32_t maxTaskWorkGroupSize_2;
	public uint32_t maxTaskTotalMemorySize;
	public uint32_t maxTaskOutputCount;
	public uint32_t maxMeshWorkGroupInvocations;
	public uint32_t maxMeshWorkGroupSize_0;
	public uint32_t maxMeshWorkGroupSize_1;
	public uint32_t maxMeshWorkGroupSize_2;
	public uint32_t maxMeshTotalMemorySize;
	public uint32_t maxMeshOutputVertices;
	public uint32_t maxMeshOutputPrimitives;
	public uint32_t maxMeshMultiviewViewCount;
	public uint32_t meshOutputPerVertexGranularity;
	public uint32_t meshOutputPerPrimitiveGranularity;
}
public unsafe struct VkDrawMeshTasksIndirectCommandNV
{
	public uint32_t taskCount;
	public uint32_t firstTask;
}
[Obsolete("Use VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR")]
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShaderBarycentric;
}
public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imageFootprint;
}
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t exclusiveScissorCount;
	public VkRect2D* pExclusiveScissors;
}
public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 exclusiveScissor;
}
public unsafe struct VkCheckpointDataNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlagBits stage;
	public void* pCheckpointMarker;
}
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags checkpointExecutionStageMask;
}
[Obsolete("Use VkPhysicalDeviceTimelineSemaphoreFeatures")]
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 timelineSemaphore;
}
[Obsolete("Use VkPhysicalDeviceTimelineSemaphoreProperties")]
public unsafe struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t maxTimelineSemaphoreValueDifference;
}
[Obsolete("Use VkSemaphoreTypeCreateInfo")]
public unsafe struct VkSemaphoreTypeCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreType semaphoreType;
	public uint64_t initialValue;
}
[Obsolete("Use VkTimelineSemaphoreSubmitInfo")]
public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t waitSemaphoreValueCount;
	public uint64_t* pWaitSemaphoreValues;
	public uint32_t signalSemaphoreValueCount;
	public uint64_t* pSignalSemaphoreValues;
}
[Obsolete("Use VkSemaphoreWaitInfo")]
public unsafe struct VkSemaphoreWaitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphoreWaitFlags flags;
	public uint32_t semaphoreCount;
	public VkSemaphore* pSemaphores;
	public uint64_t* pValues;
}
[Obsolete("Use VkSemaphoreSignalInfo")]
public unsafe struct VkSemaphoreSignalInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public uint64_t value;
}
public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderIntegerFunctions2;
}
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public void* pUserData;
}
public unsafe struct VkPerformanceMarkerInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t marker;
}
public unsafe struct VkPerformanceStreamMarkerInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t marker;
}
public unsafe struct VkPerformanceOverrideInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceOverrideTypeINTEL type;
	public VkBool32 enable;
	public uint64_t parameter;
}
public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkPerformanceConfigurationTypeINTEL type;
}
public unsafe struct VkPerformanceValueINTEL
{
	public VkPerformanceValueTypeINTEL type;
	public VkPerformanceValueDataINTEL data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPerformanceValueDataINTEL
{
	[FieldOffset(0)]
	public uint32_t value32;
	[FieldOffset(0)]
	public uint64_t value64;
	[FieldOffset(0)]
	public float valueFloat;
	[FieldOffset(0)]
	public VkBool32 valueBool;
	[FieldOffset(0)]
	public char* valueString;
}
[Obsolete("Use VkQueryPoolPerformanceQueryCreateInfoINTEL")]
public unsafe struct VkQueryPoolCreateInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
}
public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
}
[Obsolete("Use VkPhysicalDeviceVulkanMemoryModelFeatures")]
public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vulkanMemoryModel;
	public VkBool32 vulkanMemoryModelDeviceScope;
	public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
}
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t pciDomain;
	public uint32_t pciBus;
	public uint32_t pciDevice;
	public uint32_t pciFunction;
}
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 localDimmingSupport;
}
public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 localDimmingEnable;
}
[Obsolete("Use VkPhysicalDeviceShaderTerminateInvocationFeatures")]
public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderTerminateInvocation;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentDensityMap;
	public VkBool32 fragmentDensityMapDynamic;
	public VkBool32 fragmentDensityMapNonSubsampledImages;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D minFragmentDensityTexelSize;
	public VkExtent2D maxFragmentDensityTexelSize;
	public VkBool32 fragmentDensityInvocations;
}
public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentReference fragmentDensityMapAttachment;
}
[Obsolete("Use VkPhysicalDeviceScalarBlockLayoutFeatures")]
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 scalarBlockLayout;
}
[Obsolete("Use VkPhysicalDeviceSubgroupSizeControlFeatures")]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subgroupSizeControl;
	public VkBool32 computeFullSubgroups;
}
[Obsolete("Use VkPhysicalDeviceSubgroupSizeControlProperties")]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t minSubgroupSize;
	public uint32_t maxSubgroupSize;
	public uint32_t maxComputeWorkgroupSubgroups;
	public VkShaderStageFlags requiredSubgroupSizeStages;
}
[Obsolete("Use VkPipelineShaderStageRequiredSubgroupSizeCreateInfo")]
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t requiredSubgroupSize;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlags sampleCounts;
	public VkExtent2D fragmentSize;
}
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkAttachmentReference2* pFragmentShadingRateAttachment;
	public VkExtent2D shadingRateAttachmentTexelSize;
}
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D fragmentSize;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineFragmentShadingRate;
	public VkBool32 primitiveFragmentShadingRate;
	public VkBool32 attachmentFragmentShadingRate;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
	public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
	public uint32_t maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
	public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
	public VkBool32 layeredShadingRateAttachments;
	public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
	public VkExtent2D maxFragmentSize;
	public uint32_t maxFragmentSizeAspectRatio;
	public uint32_t maxFragmentShadingRateCoverageSamples;
	public VkSampleCountFlagBits maxFragmentShadingRateRasterizationSamples;
	public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
	public VkBool32 fragmentShadingRateWithSampleMask;
	public VkBool32 fragmentShadingRateWithShaderSampleMask;
	public VkBool32 fragmentShadingRateWithConservativeRasterization;
	public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
	public VkBool32 fragmentShadingRateWithCustomSampleLocations;
	public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
}
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
	public uint32_t activeComputeUnitCount;
}
public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceCoherentMemory;
}
public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderImageInt64Atomics;
	public VkBool32 sparseImageInt64Atomics;
}
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize heapBudget_0;
	public VkDeviceSize heapBudget_1;
	public VkDeviceSize heapBudget_2;
	public VkDeviceSize heapBudget_3;
	public VkDeviceSize heapBudget_4;
	public VkDeviceSize heapBudget_5;
	public VkDeviceSize heapBudget_6;
	public VkDeviceSize heapBudget_7;
	public VkDeviceSize heapBudget_8;
	public VkDeviceSize heapBudget_9;
	public VkDeviceSize heapBudget_10;
	public VkDeviceSize heapBudget_11;
	public VkDeviceSize heapBudget_12;
	public VkDeviceSize heapBudget_13;
	public VkDeviceSize heapBudget_14;
	public VkDeviceSize heapBudget_15;
	public VkDeviceSize heapUsage_0;
	public VkDeviceSize heapUsage_1;
	public VkDeviceSize heapUsage_2;
	public VkDeviceSize heapUsage_3;
	public VkDeviceSize heapUsage_4;
	public VkDeviceSize heapUsage_5;
	public VkDeviceSize heapUsage_6;
	public VkDeviceSize heapUsage_7;
	public VkDeviceSize heapUsage_8;
	public VkDeviceSize heapUsage_9;
	public VkDeviceSize heapUsage_10;
	public VkDeviceSize heapUsage_11;
	public VkDeviceSize heapUsage_12;
	public VkDeviceSize heapUsage_13;
	public VkDeviceSize heapUsage_14;
	public VkDeviceSize heapUsage_15;
}
public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 memoryPriority;
}
public unsafe struct VkMemoryPriorityAllocateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public float priority;
}
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 supportsProtected;
}
public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dedicatedAllocationImageAliasing;
}
[Obsolete("Use VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures")]
public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 separateDepthStencilLayouts;
}
[Obsolete("Use VkAttachmentReferenceStencilLayout")]
public unsafe struct VkAttachmentReferenceStencilLayoutKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilLayout;
}
[Obsolete("Use VkAttachmentDescriptionStencilLayout")]
public unsafe struct VkAttachmentDescriptionStencilLayoutKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageLayout stencilInitialLayout;
	public VkImageLayout stencilFinalLayout;
}
[Obsolete("Use VkPhysicalDeviceBufferDeviceAddressFeaturesEXT")]
public unsafe struct VkPhysicalDeviceBufferAddressFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
[Obsolete("Use VkBufferDeviceAddressInfo")]
public unsafe struct VkBufferDeviceAddressInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkBufferDeviceAddressCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress deviceAddress;
}
[Obsolete("Use VkPhysicalDeviceToolProperties")]
public unsafe struct VkPhysicalDeviceToolPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char name[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public fixed char version[VK.VK_MAX_EXTENSION_NAME_SIZE];
	public VkToolPurposeFlags purposes;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char layer[VK.VK_MAX_EXTENSION_NAME_SIZE];
}
[Obsolete("Use VkImageStencilUsageCreateInfo")]
public unsafe struct VkImageStencilUsageCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageUsageFlags stencilUsage;
}
public unsafe struct VkValidationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t enabledValidationFeatureCount;
	public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
	public uint32_t disabledValidationFeatureCount;
	public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}
public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentWait;
}
public unsafe struct VkCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t MSize;
	public uint32_t NSize;
	public uint32_t KSize;
	public VkComponentTypeNV AType;
	public VkComponentTypeNV BType;
	public VkComponentTypeNV CType;
	public VkComponentTypeNV DType;
	public VkScopeNV scope;
}
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 cooperativeMatrix;
	public VkBool32 cooperativeMatrixRobustBufferAccess;
}
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderStageFlags cooperativeMatrixSupportedStages;
}
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkCoverageReductionModeNV coverageReductionMode;
	public VkSampleCountFlagBits rasterizationSamples;
	public VkSampleCountFlags depthStencilSamples;
	public VkSampleCountFlags colorSamples;
}
public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 coverageReductionMode;
}
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineCoverageReductionStateCreateFlagsNV flags;
	public VkCoverageReductionModeNV coverageReductionMode;
}
public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShaderSampleInterlock;
	public VkBool32 fragmentShaderPixelInterlock;
	public VkBool32 fragmentShaderShadingRateInterlock;
}
public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 ycbcrImageArrays;
}
[Obsolete("Use VkPhysicalDeviceUniformBufferStandardLayoutFeatures")]
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 uniformBufferStandardLayout;
}
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 provokingVertexLast;
	public VkBool32 transformFeedbackPreservesProvokingVertex;
}
public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 provokingVertexModePerPipeline;
	public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
}
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkProvokingVertexModeEXT provokingVertexMode;
}
public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkFullScreenExclusiveEXT fullScreenExclusive;
}
public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fullScreenExclusiveSupported;
}
public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public HMONITOR hmonitor;
}
public unsafe struct VkHeadlessSurfaceCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkHeadlessSurfaceCreateFlagsEXT flags;
}
[Obsolete("Use VkPhysicalDeviceBufferDeviceAddressFeatures")]
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 bufferDeviceAddress;
	public VkBool32 bufferDeviceAddressCaptureReplay;
	public VkBool32 bufferDeviceAddressMultiDevice;
}
[Obsolete("Use VkBufferDeviceAddressInfo")]
public unsafe struct VkBufferDeviceAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
[Obsolete("Use VkBufferOpaqueCaptureAddressCreateInfo")]
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t opaqueCaptureAddress;
}
[Obsolete("Use VkMemoryOpaqueCaptureAddressAllocateInfo")]
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t opaqueCaptureAddress;
}
[Obsolete("Use VkDeviceMemoryOpaqueCaptureAddressInfo")]
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
}
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rectangularLines;
	public VkBool32 bresenhamLines;
	public VkBool32 smoothLines;
	public VkBool32 stippledRectangularLines;
	public VkBool32 stippledBresenhamLines;
	public VkBool32 stippledSmoothLines;
}
public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t lineSubPixelPrecisionBits;
}
public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkLineRasterizationModeEXT lineRasterizationMode;
	public VkBool32 stippledLineEnable;
	public uint32_t lineStippleFactor;
	public uint16_t lineStipplePattern;
}
public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferFloat32Atomics;
	public VkBool32 shaderBufferFloat32AtomicAdd;
	public VkBool32 shaderBufferFloat64Atomics;
	public VkBool32 shaderBufferFloat64AtomicAdd;
	public VkBool32 shaderSharedFloat32Atomics;
	public VkBool32 shaderSharedFloat32AtomicAdd;
	public VkBool32 shaderSharedFloat64Atomics;
	public VkBool32 shaderSharedFloat64AtomicAdd;
	public VkBool32 shaderImageFloat32Atomics;
	public VkBool32 shaderImageFloat32AtomicAdd;
	public VkBool32 sparseImageFloat32Atomics;
	public VkBool32 sparseImageFloat32AtomicAdd;
}
[Obsolete("Use VkPhysicalDeviceHostQueryResetFeatures")]
public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 hostQueryReset;
}
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 indexTypeUint8;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 extendedDynamicState;
}
public unsafe struct VkPipelineInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
}
public unsafe struct VkPipelineExecutablePropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkShaderStageFlags stages;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public uint32_t subgroupSize;
}
public unsafe struct VkPipelineExecutableInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
	public uint32_t executableIndex;
}
public unsafe struct VkPipelineExecutableStatisticKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public VkPipelineExecutableStatisticFormatKHR format;
	public VkPipelineExecutableStatisticValueKHR value;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkPipelineExecutableStatisticValueKHR
{
	[FieldOffset(0)]
	public VkBool32 b32;
	[FieldOffset(0)]
	public int64_t i64;
	[FieldOffset(0)]
	public uint64_t u64;
	[FieldOffset(0)]
	public double f64;
}
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char name[VK.VK_MAX_DESCRIPTION_SIZE];
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public VkBool32 isText;
	public size_t dataSize;
	public void* pData;
}
public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineExecutableInfo;
}
public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderBufferFloat16Atomics;
	public VkBool32 shaderBufferFloat16AtomicAdd;
	public VkBool32 shaderBufferFloat16AtomicMinMax;
	public VkBool32 shaderBufferFloat32AtomicMinMax;
	public VkBool32 shaderBufferFloat64AtomicMinMax;
	public VkBool32 shaderSharedFloat16Atomics;
	public VkBool32 shaderSharedFloat16AtomicAdd;
	public VkBool32 shaderSharedFloat16AtomicMinMax;
	public VkBool32 shaderSharedFloat32AtomicMinMax;
	public VkBool32 shaderSharedFloat64AtomicMinMax;
	public VkBool32 shaderImageFloat32AtomicMinMax;
	public VkBool32 sparseImageFloat32AtomicMinMax;
}
public unsafe struct VkSurfacePresentModeEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPresentModeKHR presentMode;
}
public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPresentScalingFlagsEXT supportedPresentScaling;
	public VkPresentGravityFlagsEXT supportedPresentGravityX;
	public VkPresentGravityFlagsEXT supportedPresentGravityY;
	public VkExtent2D minScaledImageExtent;
	public VkExtent2D maxScaledImageExtent;
}
public unsafe struct VkSurfacePresentModeCompatibilityEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t presentModeCount;
	public VkPresentModeKHR* pPresentModes;
}
public unsafe struct VkReleaseSwapchainImagesInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSwapchainKHR swapchain;
	public uint32_t imageIndexCount;
	public uint32_t* pImageIndices;
}
public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 swapchainMaintenance1;
}
public unsafe struct VkSwapchainPresentFenceInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public VkFence* pFences;
}
public unsafe struct VkSwapchainPresentModesCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t presentModeCount;
	public VkPresentModeKHR* pPresentModes;
}
public unsafe struct VkSwapchainPresentModeInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public VkPresentModeKHR* pPresentModes;
}
public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPresentScalingFlagsEXT scalingBehavior;
	public VkPresentGravityFlagsEXT presentGravityX;
	public VkPresentGravityFlagsEXT presentGravityY;
}
[Obsolete("Use VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures")]
public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderDemoteToHelperInvocation;
}
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipeline pipeline;
	public VkIndirectCommandsLayoutNV indirectCommandsLayout;
	public uint32_t maxSequencesCount;
}
public unsafe struct VkGeneratedCommandsInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineBindPoint pipelineBindPoint;
	public VkPipeline pipeline;
	public VkIndirectCommandsLayoutNV indirectCommandsLayout;
	public uint32_t streamCount;
	public VkIndirectCommandsStreamNV* pStreams;
	public uint32_t sequencesCount;
	public VkBuffer preprocessBuffer;
	public VkDeviceSize preprocessOffset;
	public VkDeviceSize preprocessSize;
	public VkBuffer sequencesCountBuffer;
	public VkDeviceSize sequencesCountOffset;
	public VkBuffer sequencesIndexBuffer;
	public VkDeviceSize sequencesIndexOffset;
}
public unsafe struct VkIndirectCommandsStreamNV
{
	public VkBuffer buffer;
	public VkDeviceSize offset;
}
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkIndirectCommandsLayoutUsageFlagsNV flags;
	public VkPipelineBindPoint pipelineBindPoint;
	public uint32_t tokenCount;
	public VkIndirectCommandsLayoutTokenNV* pTokens;
	public uint32_t streamCount;
	public uint32_t* pStreamStrides;
}
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkIndirectCommandsTokenTypeNV tokenType;
	public uint32_t stream;
	public uint32_t offset;
	public uint32_t vertexBindingUnit;
	public VkBool32 vertexDynamicStride;
	public VkPipelineLayout pushconstantPipelineLayout;
	public VkShaderStageFlags pushconstantShaderStageFlags;
	public uint32_t pushconstantOffset;
	public uint32_t pushconstantSize;
	public VkIndirectStateFlagsNV indirectStateFlags;
	public uint32_t indexTypeCount;
	public VkIndexType* pIndexTypes;
	public uint32_t* pIndexTypeValues;
}
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxGraphicsShaderGroupCount;
	public uint32_t maxIndirectSequenceCount;
	public uint32_t maxIndirectCommandsTokenCount;
	public uint32_t maxIndirectCommandsStreamCount;
	public uint32_t maxIndirectCommandsTokenOffset;
	public uint32_t maxIndirectCommandsStreamStride;
	public uint32_t minSequencesCountBufferOffsetAlignment;
	public uint32_t minSequencesIndexBufferOffsetAlignment;
	public uint32_t minIndirectCommandsBufferOffsetAlignment;
}
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceGeneratedCommands;
}
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t stageCount;
	public VkPipelineShaderStageCreateInfo* pStages;
	public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
	public VkPipelineTessellationStateCreateInfo* pTessellationState;
}
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t groupCount;
	public VkGraphicsShaderGroupCreateInfoNV* pGroups;
	public uint32_t pipelineCount;
	public VkPipeline* pPipelines;
}
public unsafe struct VkBindShaderGroupIndirectCommandNV
{
	public uint32_t groupIndex;
}
public unsafe struct VkBindIndexBufferIndirectCommandNV
{
	public VkDeviceAddress bufferAddress;
	public uint32_t size;
	public VkIndexType indexType;
}
public unsafe struct VkBindVertexBufferIndirectCommandNV
{
	public VkDeviceAddress bufferAddress;
	public uint32_t size;
	public uint32_t stride;
}
public unsafe struct VkSetStateFlagsIndirectCommandNV
{
	public uint32_t data;
}
public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 inheritedViewportScissor2D;
}
public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 viewportScissor2D;
	public uint32_t viewportDepthCount;
	public VkViewport* pViewportDepths;
}
[Obsolete("Use VkPhysicalDeviceShaderIntegerDotProductFeatures")]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderIntegerDotProduct;
}
[Obsolete("Use VkPhysicalDeviceShaderIntegerDotProductProperties")]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 integerDotProduct8BitUnsignedAccelerated;
	public VkBool32 integerDotProduct8BitSignedAccelerated;
	public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProduct16BitUnsignedAccelerated;
	public VkBool32 integerDotProduct16BitSignedAccelerated;
	public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct32BitUnsignedAccelerated;
	public VkBool32 integerDotProduct32BitSignedAccelerated;
	public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProduct64BitUnsignedAccelerated;
	public VkBool32 integerDotProduct64BitSignedAccelerated;
	public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
	public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 texelBufferAlignment;
}
[Obsolete("Use VkPhysicalDeviceTexelBufferAlignmentProperties")]
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
	public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
	public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
	public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
}
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceTransformFlagBitsKHR transform;
}
public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceTransformFlagBitsKHR transform;
	public VkRect2D renderArea;
}
public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceMemoryReport;
}
public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemoryReportFlagsEXT flags;
	public PFN_vkDeviceMemoryReportCallbackEXT pfnUserCallback;
	public void* pUserData;
}
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemoryReportFlagsEXT flags;
	public VkDeviceMemoryReportEventTypeEXT type;
	public uint64_t memoryObjectId;
	public VkDeviceSize size;
	public VkObjectType objectType;
	public uint64_t objectHandle;
	public uint32_t heapIndex;
}
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustBufferAccess2;
	public VkBool32 robustImageAccess2;
	public VkBool32 nullDescriptor;
}
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize robustStorageBufferAccessSizeAlignment;
	public VkDeviceSize robustUniformBufferAccessSizeAlignment;
}
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkClearColorValue customBorderColor;
	public VkFormat format;
}
public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxCustomBorderColorSamplers;
}
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 customBorderColors;
	public VkBool32 customBorderColorWithoutFormat;
}
public unsafe struct VkPhysicalDevicePresentBarrierFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentBarrier;
}
public unsafe struct VkSurfaceCapabilitiesPresentBarrierNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentBarrierSupported;
}
public unsafe struct VkSwapchainPresentBarrierCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentBarrierEnable;
}
public unsafe struct VkPresentIdKHR
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t swapchainCount;
	public uint64_t* pPresentIds;
}
public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 presentId;
}
[Obsolete("Use VkPhysicalDevicePrivateDataFeatures")]
public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 privateData;
}
[Obsolete("Use VkDevicePrivateDataCreateInfo")]
public unsafe struct VkDevicePrivateDataCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t privateDataSlotRequestCount;
}
[Obsolete("Use VkPrivateDataSlotCreateInfo")]
public unsafe struct VkPrivateDataSlotCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPrivateDataSlotCreateFlags flags;
}
[Obsolete("Use VkPhysicalDevicePipelineCreationCacheControlFeatures")]
public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineCreationCacheControl;
}
public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 diagnosticsConfig;
}
public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceDiagnosticsConfigFlagsNV flags;
}
[Obsolete("Use VkMemoryBarrier2")]
public unsafe struct VkMemoryBarrier2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
}
[Obsolete("Use VkBufferMemoryBarrier2")]
public unsafe struct VkBufferMemoryBarrier2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
}
[Obsolete("Use VkImageMemoryBarrier2")]
public unsafe struct VkImageMemoryBarrier2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 srcStageMask;
	public VkAccessFlags2 srcAccessMask;
	public VkPipelineStageFlags2 dstStageMask;
	public VkAccessFlags2 dstAccessMask;
	public VkImageLayout oldLayout;
	public VkImageLayout newLayout;
	public uint32_t srcQueueFamilyIndex;
	public uint32_t dstQueueFamilyIndex;
	public VkImage image;
	public VkImageSubresourceRange subresourceRange;
}
[Obsolete("Use VkDependencyInfo")]
public unsafe struct VkDependencyInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDependencyFlags dependencyFlags;
	public uint32_t memoryBarrierCount;
	public VkMemoryBarrier2* pMemoryBarriers;
	public uint32_t bufferMemoryBarrierCount;
	public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
	public uint32_t imageMemoryBarrierCount;
	public VkImageMemoryBarrier2* pImageMemoryBarriers;
}
[Obsolete("Use VkSubmitInfo2")]
public unsafe struct VkSubmitInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubmitFlags flags;
	public uint32_t waitSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
	public uint32_t commandBufferInfoCount;
	public VkCommandBufferSubmitInfo* pCommandBufferInfos;
	public uint32_t signalSemaphoreInfoCount;
	public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}
[Obsolete("Use VkSemaphoreSubmitInfo")]
public unsafe struct VkSemaphoreSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkSemaphore semaphore;
	public uint64_t value;
	public VkPipelineStageFlags2 stageMask;
	public uint32_t deviceIndex;
}
[Obsolete("Use VkCommandBufferSubmitInfo")]
public unsafe struct VkCommandBufferSubmitInfoKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkCommandBuffer commandBuffer;
	public uint32_t deviceMask;
}
[Obsolete("Use VkPhysicalDeviceSynchronization2Features")]
public unsafe struct VkPhysicalDeviceSynchronization2FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 synchronization2;
}
public unsafe struct VkCheckpointData2NV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 stage;
	public void* pCheckpointMarker;
}
public unsafe struct VkQueueFamilyCheckpointProperties2NV
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipelineStageFlags2 checkpointExecutionStageMask;
}
public unsafe struct VkDescriptorGetInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorType type;
	public VkDescriptorDataEXT data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkDescriptorDataEXT
{
	[FieldOffset(0)]
	public VkSampler* pSampler;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pCombinedImageSampler;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pInputAttachmentImage;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pSampledImage;
	[FieldOffset(0)]
	public VkDescriptorImageInfo* pStorageImage;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pUniformBuffer;
	[FieldOffset(0)]
	public VkDescriptorAddressInfoEXT* pStorageBuffer;
	[FieldOffset(0)]
	public VkDeviceAddress accelerationStructure;
}
public unsafe struct VkDescriptorAddressInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress address;
	public VkDeviceSize range;
	public VkFormat format;
}
public unsafe struct VkDescriptorBufferBindingInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddress address;
	public VkBufferUsageFlags usage;
}
public unsafe struct VkBufferCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkImageCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage image;
}
public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageView imageView;
}
public unsafe struct VkSamplerCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampler sampler;
}
public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 combinedImageSamplerDescriptorSingleArray;
	public VkBool32 bufferlessPushDescriptors;
	public VkBool32 allowSamplerImageViewPostSubmitCreation;
	public VkDeviceSize descriptorBufferOffsetAlignment;
	public uint32_t maxDescriptorBufferBindings;
	public uint32_t maxResourceDescriptorBufferBindings;
	public uint32_t maxSamplerDescriptorBufferBindings;
	public uint32_t maxEmbeddedImmutableSamplerBindings;
	public uint32_t maxEmbeddedImmutableSamplers;
	public size_t bufferCaptureReplayDescriptorDataSize;
	public size_t imageCaptureReplayDescriptorDataSize;
	public size_t imageViewCaptureReplayDescriptorDataSize;
	public size_t samplerCaptureReplayDescriptorDataSize;
	public size_t accelerationStructureCaptureReplayDescriptorDataSize;
	public size_t samplerDescriptorSize;
	public size_t combinedImageSamplerDescriptorSize;
	public size_t sampledImageDescriptorSize;
	public size_t storageImageDescriptorSize;
	public size_t uniformTexelBufferDescriptorSize;
	public size_t robustUniformTexelBufferDescriptorSize;
	public size_t storageTexelBufferDescriptorSize;
	public size_t robustStorageTexelBufferDescriptorSize;
	public size_t uniformBufferDescriptorSize;
	public size_t robustUniformBufferDescriptorSize;
	public size_t storageBufferDescriptorSize;
	public size_t robustStorageBufferDescriptorSize;
	public size_t inputAttachmentDescriptorSize;
	public size_t accelerationStructureDescriptorSize;
	public VkDeviceSize maxSamplerDescriptorBufferRange;
	public VkDeviceSize maxResourceDescriptorBufferRange;
	public VkDeviceSize samplerDescriptorBufferAddressSpaceSize;
	public VkDeviceSize resourceDescriptorBufferAddressSpaceSize;
	public VkDeviceSize descriptorBufferAddressSpaceSize;
}
public unsafe struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public size_t combinedImageSamplerDensityMapDescriptorSize;
}
public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 descriptorBuffer;
	public VkBool32 descriptorBufferCaptureReplay;
	public VkBool32 descriptorBufferImageLayoutIgnored;
	public VkBool32 descriptorBufferPushDescriptors;
}
public unsafe struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer buffer;
}
public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public void* opaqueCaptureDescriptorData;
}
public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkAccelerationStructureKHR accelerationStructure;
	public VkAccelerationStructureNV accelerationStructureNV;
}
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 graphicsPipelineLibrary;
}
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 graphicsPipelineLibraryFastLinking;
	public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;
}
public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkGraphicsPipelineLibraryFlagsEXT flags;
}
public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderEarlyAndLateFragmentTests;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShaderBarycentric;
}
public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 triStripVertexOrderIndependentOfProvokingVertex;
}
public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderSubgroupUniformControlFlow;
}
[Obsolete("Use VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures")]
public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderZeroInitializeWorkgroupMemory;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentShadingRateEnums;
	public VkBool32 supersampleFragmentShadingRates;
	public VkBool32 noInvocationFragmentShadingRates;
}
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkSampleCountFlagBits maxFragmentShadingRateInvocationCount;
}
public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkFragmentShadingRateTypeNV shadingRateType;
	public VkFragmentShadingRateNV shadingRate;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
	public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
}
public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR vertexData;
}
public unsafe struct VkAccelerationStructureMotionInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxInstances;
	public VkAccelerationStructureMotionInfoFlagsNV flags;
}
public unsafe struct VkAccelerationStructureMotionInstanceNV
{
	public VkAccelerationStructureMotionInstanceTypeNV type;
	public VkAccelerationStructureMotionInstanceFlagsNV flags;
	public VkAccelerationStructureMotionInstanceDataNV data;
}
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkAccelerationStructureMotionInstanceDataNV
{
	[FieldOffset(0)]
	public VkAccelerationStructureInstanceKHR staticInstance;
	[FieldOffset(0)]
	public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;
	[FieldOffset(0)]
	public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
}
public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
{
	public VkTransformMatrixKHR transformT0;
	public VkTransformMatrixKHR transformT1;
	public uint32_t instanceCustomIndex;
	public uint32_t mask;
	public uint32_t instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public uint64_t accelerationStructureReference;
}
public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
{
	public VkSRTDataNV transformT0;
	public VkSRTDataNV transformT1;
	public uint32_t instanceCustomIndex;
	public uint32_t mask;
	public uint32_t instanceShaderBindingTableRecordOffset;
	public VkGeometryInstanceFlagsKHR flags;
	public uint64_t accelerationStructureReference;
}
public unsafe struct VkSRTDataNV
{
	public float sx;
	public float a;
	public float b;
	public float pvx;
	public float sy;
	public float c;
	public float pvy;
	public float sz;
	public float pvz;
	public float qx;
	public float qy;
	public float qz;
	public float qw;
	public float tx;
	public float ty;
	public float tz;
}
public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingMotionBlur;
	public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;
}
public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 taskShader;
	public VkBool32 meshShader;
	public VkBool32 multiviewMeshShader;
	public VkBool32 primitiveFragmentShadingRateMeshShader;
	public VkBool32 meshShaderQueries;
}
public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxTaskWorkGroupTotalCount;
	public uint32_t maxTaskWorkGroupCount_0;
	public uint32_t maxTaskWorkGroupCount_1;
	public uint32_t maxTaskWorkGroupCount_2;
	public uint32_t maxTaskWorkGroupInvocations;
	public uint32_t maxTaskWorkGroupSize_0;
	public uint32_t maxTaskWorkGroupSize_1;
	public uint32_t maxTaskWorkGroupSize_2;
	public uint32_t maxTaskPayloadSize;
	public uint32_t maxTaskSharedMemorySize;
	public uint32_t maxTaskPayloadAndSharedMemorySize;
	public uint32_t maxMeshWorkGroupTotalCount;
	public uint32_t maxMeshWorkGroupCount_0;
	public uint32_t maxMeshWorkGroupCount_1;
	public uint32_t maxMeshWorkGroupCount_2;
	public uint32_t maxMeshWorkGroupInvocations;
	public uint32_t maxMeshWorkGroupSize_0;
	public uint32_t maxMeshWorkGroupSize_1;
	public uint32_t maxMeshWorkGroupSize_2;
	public uint32_t maxMeshSharedMemorySize;
	public uint32_t maxMeshPayloadAndSharedMemorySize;
	public uint32_t maxMeshOutputMemorySize;
	public uint32_t maxMeshPayloadAndOutputMemorySize;
	public uint32_t maxMeshOutputComponents;
	public uint32_t maxMeshOutputVertices;
	public uint32_t maxMeshOutputPrimitives;
	public uint32_t maxMeshOutputLayers;
	public uint32_t maxMeshMultiviewViewCount;
	public uint32_t meshOutputPerVertexGranularity;
	public uint32_t meshOutputPerPrimitiveGranularity;
	public uint32_t maxPreferredTaskWorkGroupInvocations;
	public uint32_t maxPreferredMeshWorkGroupInvocations;
	public VkBool32 prefersLocalInvocationVertexOutput;
	public VkBool32 prefersLocalInvocationPrimitiveOutput;
	public VkBool32 prefersCompactVertexOutput;
	public VkBool32 prefersCompactPrimitiveOutput;
}
public unsafe struct VkDrawMeshTasksIndirectCommandEXT
{
	public uint32_t groupCountX;
	public uint32_t groupCountY;
	public uint32_t groupCountZ;
}
public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 ycbcr2plane444Formats;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentDensityMapDeferred;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subsampledLoads;
	public VkBool32 subsampledCoarseReconstructionEarlyAccess;
	public uint32_t maxSubsampledArrayLayers;
	public uint32_t maxDescriptorSetSubsampledSamplers;
}
public unsafe struct VkCopyCommandTransformInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkSurfaceTransformFlagBitsKHR transform;
}
[Obsolete("Use VkPhysicalDeviceImageRobustnessFeatures")]
public unsafe struct VkPhysicalDeviceImageRobustnessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 robustImageAccess;
}
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 workgroupMemoryExplicitLayout;
	public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
	public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
	public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
}
[Obsolete("Use VkCopyBufferInfo2")]
public unsafe struct VkCopyBufferInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkBuffer dstBuffer;
	public uint32_t regionCount;
	public VkBufferCopy2* pRegions;
}
[Obsolete("Use VkCopyImageInfo2")]
public unsafe struct VkCopyImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkImageCopy2* pRegions;
}
[Obsolete("Use VkCopyBufferToImageInfo2")]
public unsafe struct VkCopyBufferToImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBuffer srcBuffer;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkBufferImageCopy2* pRegions;
}
[Obsolete("Use VkCopyImageToBufferInfo2")]
public unsafe struct VkCopyImageToBufferInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkBuffer dstBuffer;
	public uint32_t regionCount;
	public VkBufferImageCopy2* pRegions;
}
[Obsolete("Use VkBlitImageInfo2")]
public unsafe struct VkBlitImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkImageBlit2* pRegions;
	public VkFilter filter;
}
[Obsolete("Use VkResolveImageInfo2")]
public unsafe struct VkResolveImageInfo2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImage srcImage;
	public VkImageLayout srcImageLayout;
	public VkImage dstImage;
	public VkImageLayout dstImageLayout;
	public uint32_t regionCount;
	public VkImageResolve2* pRegions;
}
[Obsolete("Use VkBufferCopy2")]
public unsafe struct VkBufferCopy2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize srcOffset;
	public VkDeviceSize dstOffset;
	public VkDeviceSize size;
}
[Obsolete("Use VkImageCopy2")]
public unsafe struct VkImageCopy2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
[Obsolete("Use VkImageBlit2")]
public unsafe struct VkImageBlit2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffsets_0;
	public VkOffset3D srcOffsets_1;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffsets_0;
	public VkOffset3D dstOffsets_1;
}
[Obsolete("Use VkBufferImageCopy2")]
public unsafe struct VkBufferImageCopy2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize bufferOffset;
	public uint32_t bufferRowLength;
	public uint32_t bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
[Obsolete("Use VkImageResolve2")]
public unsafe struct VkImageResolve2KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresourceLayers srcSubresource;
	public VkOffset3D srcOffset;
	public VkImageSubresourceLayers dstSubresource;
	public VkOffset3D dstOffset;
	public VkExtent3D extent;
}
public unsafe struct VkImageSubresource2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageSubresource imageSubresource;
}
public unsafe struct VkSubresourceLayout2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkSubresourceLayout subresourceLayout;
}
public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imageCompressionControl;
}
public unsafe struct VkImageCompressionControlEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCompressionFlagsEXT flags;
	public uint32_t compressionControlPlaneCount;
	public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;
}
public unsafe struct VkImageCompressionPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCompressionFlagsEXT imageCompressionFlags;
	public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;
}
public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 attachmentFeedbackLoopLayout;
}
public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 formatA4R4G4B4;
	public VkBool32 formatA4B4G4R4;
}
public unsafe struct VkDeviceFaultCountsEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t addressInfoCount;
	public uint32_t vendorInfoCount;
	public VkDeviceSize vendorBinarySize;
}
public unsafe struct VkDeviceFaultInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public VkDeviceFaultAddressInfoEXT* pAddressInfos;
	public VkDeviceFaultVendorInfoEXT* pVendorInfos;
	public void* pVendorBinaryData;
}
public unsafe struct VkDeviceFaultAddressInfoEXT
{
	public VkDeviceFaultAddressTypeEXT addressType;
	public VkDeviceAddress reportedAddress;
	public VkDeviceSize addressPrecision;
}
public unsafe struct VkDeviceFaultVendorInfoEXT
{
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public uint64_t vendorFaultCode;
	public uint64_t vendorFaultData;
}
public unsafe struct VkPhysicalDeviceFaultFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 deviceFault;
	public VkBool32 deviceFaultVendorBinary;
}
public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
	public uint32_t headerSize;
	public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
	public uint32_t vendorID;
	public uint32_t deviceID;
	public uint32_t driverVersion;
	public uint8_t pipelineCacheUUID_0;
	public uint8_t pipelineCacheUUID_1;
	public uint8_t pipelineCacheUUID_2;
	public uint8_t pipelineCacheUUID_3;
	public uint8_t pipelineCacheUUID_4;
	public uint8_t pipelineCacheUUID_5;
	public uint8_t pipelineCacheUUID_6;
	public uint8_t pipelineCacheUUID_7;
	public uint8_t pipelineCacheUUID_8;
	public uint8_t pipelineCacheUUID_9;
	public uint8_t pipelineCacheUUID_10;
	public uint8_t pipelineCacheUUID_11;
	public uint8_t pipelineCacheUUID_12;
	public uint8_t pipelineCacheUUID_13;
	public uint8_t pipelineCacheUUID_14;
	public uint8_t pipelineCacheUUID_15;
	public uint32_t applicationNameOffset;
	public uint32_t applicationVersion;
	public uint32_t engineNameOffset;
}
[Obsolete("Use VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT")]
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rasterizationOrderColorAttachmentAccess;
	public VkBool32 rasterizationOrderDepthAttachmentAccess;
	public VkBool32 rasterizationOrderStencilAttachmentAccess;
}
public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 formatRgba10x6WithoutYCbCrSampler;
}
[Obsolete("Use VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT")]
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 mutableDescriptorType;
}
[Obsolete("Use VkMutableDescriptorTypeListEXT")]
public unsafe struct VkMutableDescriptorTypeListVALVE
{
	public uint32_t descriptorTypeCount;
	public VkDescriptorType* pDescriptorTypes;
}
[Obsolete("Use VkMutableDescriptorTypeCreateInfoEXT")]
public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t mutableDescriptorTypeListCount;
	public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
}
public unsafe struct VkVertexInputBindingDescription2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t binding;
	public uint32_t stride;
	public VkVertexInputRate inputRate;
	public uint32_t divisor;
}
public unsafe struct VkVertexInputAttributeDescription2EXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t location;
	public uint32_t binding;
	public VkFormat format;
	public uint32_t offset;
}
public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 vertexInputDynamicState;
}
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 hasPrimary;
	public VkBool32 hasRender;
	public int64_t primaryMajor;
	public int64_t primaryMinor;
	public int64_t renderMajor;
	public int64_t renderMinor;
}
public unsafe struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 reportAddressBinding;
}
public unsafe struct VkDeviceAddressBindingCallbackDataEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceAddressBindingFlagsEXT flags;
	public VkDeviceAddress baseAddress;
	public VkDeviceSize size;
	public VkDeviceAddressBindingTypeEXT bindingType;
}
public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 depthClipControl;
}
public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 negativeOneToOne;
}
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 primitiveTopologyListRestart;
	public VkBool32 primitiveTopologyPatchListRestart;
}
[Obsolete("Use VkFormatProperties3")]
public unsafe struct VkFormatProperties3KHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormatFeatureFlags2 linearTilingFeatures;
	public VkFormatFeatureFlags2 optimalTilingFeatures;
	public VkFormatFeatureFlags2 bufferFeatures;
}
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPass renderPass;
	public uint32_t subpass;
}
public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subpassShading;
}
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxSubpassShadingWorkgroupSizeAspectRatio;
}
public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 invocationMask;
}
public unsafe struct VkMemoryGetRemoteAddressInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceMemory memory;
	public VkExternalMemoryHandleTypeFlagBits handleType;
}
public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 externalMemoryRDMA;
}
[Obsolete("Use VkPipelineInfoKHR")]
public unsafe struct VkPipelineInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkPipeline pipeline;
}
public unsafe struct VkPipelinePropertiesIdentifierEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t pipelineIdentifier_0;
	public uint8_t pipelineIdentifier_1;
	public uint8_t pipelineIdentifier_2;
	public uint8_t pipelineIdentifier_3;
	public uint8_t pipelineIdentifier_4;
	public uint8_t pipelineIdentifier_5;
	public uint8_t pipelineIdentifier_6;
	public uint8_t pipelineIdentifier_7;
	public uint8_t pipelineIdentifier_8;
	public uint8_t pipelineIdentifier_9;
	public uint8_t pipelineIdentifier_10;
	public uint8_t pipelineIdentifier_11;
	public uint8_t pipelineIdentifier_12;
	public uint8_t pipelineIdentifier_13;
	public uint8_t pipelineIdentifier_14;
	public uint8_t pipelineIdentifier_15;
}
public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelinePropertiesIdentifier;
}
public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multisampledRenderToSingleSampled;
}
public unsafe struct VkSubpassResolvePerformanceQueryEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 optimal;
}
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multisampledRenderToSingleSampledEnable;
	public VkSampleCountFlagBits rasterizationSamples;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 extendedDynamicState2;
	public VkBool32 extendedDynamicState2LogicOp;
	public VkBool32 extendedDynamicState2PatchControlPoints;
}
public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 colorWriteEnable;
}
public unsafe struct VkPipelineColorWriteCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t attachmentCount;
	public VkBool32* pColorWriteEnables;
}
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 primitivesGeneratedQuery;
	public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
	public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
}
public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingMaintenance1;
	public VkBool32 rayTracingPipelineTraceRaysIndirect2;
}
public unsafe struct VkTraceRaysIndirectCommand2KHR
{
	public VkDeviceAddress raygenShaderRecordAddress;
	public VkDeviceSize raygenShaderRecordSize;
	public VkDeviceAddress missShaderBindingTableAddress;
	public VkDeviceSize missShaderBindingTableSize;
	public VkDeviceSize missShaderBindingTableStride;
	public VkDeviceAddress hitShaderBindingTableAddress;
	public VkDeviceSize hitShaderBindingTableSize;
	public VkDeviceSize hitShaderBindingTableStride;
	public VkDeviceAddress callableShaderBindingTableAddress;
	public VkDeviceSize callableShaderBindingTableSize;
	public VkDeviceSize callableShaderBindingTableStride;
	public uint32_t width;
	public uint32_t height;
	public uint32_t depth;
}
[Obsolete("Use VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR")]
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 globalPriorityQuery;
}
[Obsolete("Use VkQueueFamilyGlobalPriorityPropertiesKHR")]
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t priorityCount;
	public VkQueueGlobalPriorityKHR priorities_0;
	public VkQueueGlobalPriorityKHR priorities_1;
	public VkQueueGlobalPriorityKHR priorities_2;
	public VkQueueGlobalPriorityKHR priorities_3;
	public VkQueueGlobalPriorityKHR priorities_4;
	public VkQueueGlobalPriorityKHR priorities_5;
	public VkQueueGlobalPriorityKHR priorities_6;
	public VkQueueGlobalPriorityKHR priorities_7;
	public VkQueueGlobalPriorityKHR priorities_8;
	public VkQueueGlobalPriorityKHR priorities_9;
	public VkQueueGlobalPriorityKHR priorities_10;
	public VkQueueGlobalPriorityKHR priorities_11;
	public VkQueueGlobalPriorityKHR priorities_12;
	public VkQueueGlobalPriorityKHR priorities_13;
	public VkQueueGlobalPriorityKHR priorities_14;
	public VkQueueGlobalPriorityKHR priorities_15;
}
public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 minLod;
}
public unsafe struct VkImageViewMinLodCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public float minLod;
}
public unsafe struct VkMultiDrawInfoEXT
{
	public uint32_t firstVertex;
	public uint32_t vertexCount;
}
public unsafe struct VkMultiDrawIndexedInfoEXT
{
	public uint32_t firstIndex;
	public uint32_t indexCount;
	public int32_t vertexOffset;
}
public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiDraw;
}
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxMultiDrawCount;
}
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 image2DViewOf3D;
	public VkBool32 sampler2DViewOf3D;
}
public unsafe struct VkMicromapCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapCreateFlagsEXT createFlags;
	public VkBuffer buffer;
	public VkDeviceSize offset;
	public VkDeviceSize size;
	public VkMicromapTypeEXT type;
	public VkDeviceAddress deviceAddress;
}
public unsafe struct VkMicromapBuildInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapTypeEXT type;
	public VkBuildMicromapFlagsEXT flags;
	public VkBuildMicromapModeEXT mode;
	public VkMicromapEXT dstMicromap;
	public uint32_t usageCountsCount;
	public VkMicromapUsageEXT* pUsageCounts;
	public VkMicromapUsageEXT** ppUsageCounts;
	public VkDeviceOrHostAddressConstKHR data;
	public VkDeviceOrHostAddressKHR scratchData;
	public VkDeviceOrHostAddressConstKHR triangleArray;
	public VkDeviceSize triangleArrayStride;
}
public unsafe struct VkMicromapUsageEXT
{
	public uint32_t count;
	public uint32_t subdivisionLevel;
	public uint32_t format;
}
public unsafe struct VkCopyMicromapInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapEXT src;
	public VkMicromapEXT dst;
	public VkCopyMicromapModeEXT mode;
}
public unsafe struct VkCopyMicromapToMemoryInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkMicromapEXT src;
	public VkDeviceOrHostAddressKHR dst;
	public VkCopyMicromapModeEXT mode;
}
public unsafe struct VkCopyMemoryToMicromapInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceOrHostAddressConstKHR src;
	public VkMicromapEXT dst;
	public VkCopyMicromapModeEXT mode;
}
public unsafe struct VkMicromapVersionInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t* pVersionData;
}
public unsafe struct VkMicromapBuildSizesInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize micromapSize;
	public VkDeviceSize buildScratchSize;
	public VkBool32 discardable;
}
public unsafe struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 micromap;
	public VkBool32 micromapCaptureReplay;
	public VkBool32 micromapHostCommands;
}
public unsafe struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxOpacity2StateSubdivisionLevel;
	public uint32_t maxOpacity4StateSubdivisionLevel;
}
public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkIndexType indexType;
	public VkDeviceOrHostAddressConstKHR indexBuffer;
	public VkDeviceSize indexStride;
	public uint32_t baseTriangle;
	public uint32_t usageCountsCount;
	public VkMicromapUsageEXT* pUsageCounts;
	public VkMicromapUsageEXT** ppUsageCounts;
	public VkMicromapEXT micromap;
}
public unsafe struct VkMicromapTriangleEXT
{
	public uint32_t dataOffset;
	public uint16_t subdivisionLevel;
	public uint16_t format;
}
public unsafe struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 clustercullingShader;
	public VkBool32 multiviewClusterCullingShader;
}
public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxWorkGroupCount_0;
	public uint32_t maxWorkGroupCount_1;
	public uint32_t maxWorkGroupCount_2;
	public uint32_t maxWorkGroupSize_0;
	public uint32_t maxWorkGroupSize_1;
	public uint32_t maxWorkGroupSize_2;
	public uint32_t maxOutputClusterCount;
}
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 borderColorSwizzle;
	public VkBool32 borderColorSwizzleFromImage;
}
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkComponentMapping components;
	public VkBool32 srgb;
}
public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pageableDeviceLocalMemory;
}
[Obsolete("Use VkPhysicalDeviceMaintenance4Features")]
public unsafe struct VkPhysicalDeviceMaintenance4FeaturesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 maintenance4;
}
[Obsolete("Use VkPhysicalDeviceMaintenance4Properties")]
public unsafe struct VkPhysicalDeviceMaintenance4PropertiesKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkDeviceSize maxBufferSize;
}
[Obsolete("Use VkDeviceBufferMemoryRequirements")]
public unsafe struct VkDeviceBufferMemoryRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkBufferCreateInfo* pCreateInfo;
}
[Obsolete("Use VkDeviceImageMemoryRequirements")]
public unsafe struct VkDeviceImageMemoryRequirementsKHR
{
	public VkStructureType sType;
	public void* pNext;
	public VkImageCreateInfo* pCreateInfo;
	public VkImageAspectFlagBits planeAspect;
}
public unsafe struct VkDescriptorSetBindingReferenceVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public VkDescriptorSetLayout descriptorSetLayout;
	public uint32_t binding;
}
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public size_t descriptorOffset;
	public uint32_t descriptorSize;
}
public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 descriptorSetHostMapping;
}
public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 depthClampZeroOne;
}
public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 nonSeamlessCubeMap;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 fragmentDensityMapOffset;
}
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent2D fragmentDensityOffsetGranularity;
}
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t fragmentDensityOffsetCount;
	public VkOffset2D* pFragmentDensityOffsets;
}
public unsafe struct VkCopyMemoryIndirectCommandNV
{
	public VkDeviceAddress srcAddress;
	public VkDeviceAddress dstAddress;
	public VkDeviceSize size;
}
public unsafe struct VkCopyMemoryToImageIndirectCommandNV
{
	public VkDeviceAddress srcAddress;
	public uint32_t bufferRowLength;
	public uint32_t bufferImageHeight;
	public VkImageSubresourceLayers imageSubresource;
	public VkOffset3D imageOffset;
	public VkExtent3D imageExtent;
}
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 indirectCopy;
}
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkQueueFlags supportedQueues;
}
public unsafe struct VkDecompressMemoryRegionNV
{
	public VkDeviceAddress srcAddress;
	public VkDeviceAddress dstAddress;
	public VkDeviceSize compressedSize;
	public VkDeviceSize decompressedSize;
	public VkMemoryDecompressionMethodFlagsNV decompressionMethod;
}
public unsafe struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 memoryDecompression;
}
public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkMemoryDecompressionMethodFlagsNV decompressionMethods;
	public uint64_t maxDecompressionIndirectCount;
}
public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 linearColorAttachment;
}
public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 imageCompressionControlSwapchain;
}
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkOffset2D filterCenter;
	public VkExtent2D filterSize;
	public uint32_t numPhases;
}
public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 textureSampleWeighted;
	public VkBool32 textureBoxFilter;
	public VkBool32 textureBlockMatch;
}
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t maxWeightFilterPhases;
	public VkExtent2D maxWeightFilterDimension;
	public VkExtent2D maxBlockMatchRegion;
	public VkExtent2D maxBoxFilterBlockSize;
}
public unsafe struct VkColorBlendEquationEXT
{
	public VkBlendFactor srcColorBlendFactor;
	public VkBlendFactor dstColorBlendFactor;
	public VkBlendOp colorBlendOp;
	public VkBlendFactor srcAlphaBlendFactor;
	public VkBlendFactor dstAlphaBlendFactor;
	public VkBlendOp alphaBlendOp;
}
public unsafe struct VkColorBlendAdvancedEXT
{
	public VkBlendOp advancedBlendOp;
	public VkBool32 srcPremultiplied;
	public VkBool32 dstPremultiplied;
	public VkBlendOverlapEXT blendOverlap;
	public VkBool32 clampResults;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 extendedDynamicState3TessellationDomainOrigin;
	public VkBool32 extendedDynamicState3DepthClampEnable;
	public VkBool32 extendedDynamicState3PolygonMode;
	public VkBool32 extendedDynamicState3RasterizationSamples;
	public VkBool32 extendedDynamicState3SampleMask;
	public VkBool32 extendedDynamicState3AlphaToCoverageEnable;
	public VkBool32 extendedDynamicState3AlphaToOneEnable;
	public VkBool32 extendedDynamicState3LogicOpEnable;
	public VkBool32 extendedDynamicState3ColorBlendEnable;
	public VkBool32 extendedDynamicState3ColorBlendEquation;
	public VkBool32 extendedDynamicState3ColorWriteMask;
	public VkBool32 extendedDynamicState3RasterizationStream;
	public VkBool32 extendedDynamicState3ConservativeRasterizationMode;
	public VkBool32 extendedDynamicState3ExtraPrimitiveOverestimationSize;
	public VkBool32 extendedDynamicState3DepthClipEnable;
	public VkBool32 extendedDynamicState3SampleLocationsEnable;
	public VkBool32 extendedDynamicState3ColorBlendAdvanced;
	public VkBool32 extendedDynamicState3ProvokingVertexMode;
	public VkBool32 extendedDynamicState3LineRasterizationMode;
	public VkBool32 extendedDynamicState3LineStippleEnable;
	public VkBool32 extendedDynamicState3DepthClipNegativeOneToOne;
	public VkBool32 extendedDynamicState3ViewportWScalingEnable;
	public VkBool32 extendedDynamicState3ViewportSwizzle;
	public VkBool32 extendedDynamicState3CoverageToColorEnable;
	public VkBool32 extendedDynamicState3CoverageToColorLocation;
	public VkBool32 extendedDynamicState3CoverageModulationMode;
	public VkBool32 extendedDynamicState3CoverageModulationTableEnable;
	public VkBool32 extendedDynamicState3CoverageModulationTable;
	public VkBool32 extendedDynamicState3CoverageReductionMode;
	public VkBool32 extendedDynamicState3RepresentativeFragmentTestEnable;
	public VkBool32 extendedDynamicState3ShadingRateImageEnable;
}
public unsafe struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 dynamicPrimitiveTopologyUnrestricted;
}
public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 subpassMergeFeedback;
}
public unsafe struct VkRenderPassCreationControlEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 disallowMerging;
}
public unsafe struct VkRenderPassCreationFeedbackInfoEXT
{
	public uint32_t postMergeSubpassCount;
}
public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;
}
public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
{
	public VkSubpassMergeStatusEXT subpassMergeStatus;
	public fixed char description[VK.VK_MAX_DESCRIPTION_SIZE];
	public uint32_t postMergeIndex;
}
public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
}
public unsafe struct VkDirectDriverLoadingInfoLUNARG
{
	public VkStructureType sType;
	public void* pNext;
	public VkDirectDriverLoadingFlagsLUNARG flags;
	public PFN_vkGetInstanceProcAddrLUNARG pfnGetInstanceProcAddr;
}
public unsafe struct VkDirectDriverLoadingListLUNARG
{
	public VkStructureType sType;
	public void* pNext;
	public VkDirectDriverLoadingModeLUNARG mode;
	public uint32_t driverCount;
	public VkDirectDriverLoadingInfoLUNARG* pDrivers;
}
public unsafe struct VkShaderModuleIdentifierEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t identifierSize;
	public uint8_t identifier_0;
	public uint8_t identifier_1;
	public uint8_t identifier_2;
	public uint8_t identifier_3;
	public uint8_t identifier_4;
	public uint8_t identifier_5;
	public uint8_t identifier_6;
	public uint8_t identifier_7;
	public uint8_t identifier_8;
	public uint8_t identifier_9;
	public uint8_t identifier_10;
	public uint8_t identifier_11;
	public uint8_t identifier_12;
	public uint8_t identifier_13;
	public uint8_t identifier_14;
	public uint8_t identifier_15;
	public uint8_t identifier_16;
	public uint8_t identifier_17;
	public uint8_t identifier_18;
	public uint8_t identifier_19;
	public uint8_t identifier_20;
	public uint8_t identifier_21;
	public uint8_t identifier_22;
	public uint8_t identifier_23;
	public uint8_t identifier_24;
	public uint8_t identifier_25;
	public uint8_t identifier_26;
	public uint8_t identifier_27;
	public uint8_t identifier_28;
	public uint8_t identifier_29;
	public uint8_t identifier_30;
	public uint8_t identifier_31;
}
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderModuleIdentifier;
}
public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_0;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_1;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_2;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_3;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_4;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_5;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_6;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_7;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_8;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_9;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_10;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_11;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_12;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_13;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_14;
	public uint8_t shaderModuleIdentifierAlgorithmUUID_15;
}
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t identifierSize;
	public uint8_t* pIdentifier;
}
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rasterizationOrderColorAttachmentAccess;
	public VkBool32 rasterizationOrderDepthAttachmentAccess;
	public VkBool32 rasterizationOrderStencilAttachmentAccess;
}
public unsafe struct VkOpticalFlowImageFormatInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkOpticalFlowUsageFlagsNV usage;
}
public unsafe struct VkOpticalFlowImageFormatPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkFormat format;
}
public unsafe struct VkOpticalFlowSessionCreateInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t width;
	public uint32_t height;
	public VkFormat imageFormat;
	public VkFormat flowVectorFormat;
	public VkFormat costFormat;
	public VkOpticalFlowGridSizeFlagsNV outputGridSize;
	public VkOpticalFlowGridSizeFlagsNV hintGridSize;
	public VkOpticalFlowPerformanceLevelNV performanceLevel;
	public VkOpticalFlowSessionCreateFlagsNV flags;
}
public unsafe struct VkOpticalFlowExecuteInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkOpticalFlowExecuteFlagsNV flags;
	public uint32_t regionCount;
	public VkRect2D* pRegions;
}
public unsafe struct VkPhysicalDeviceOpticalFlowFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 opticalFlow;
}
public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;
	public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;
	public VkBool32 hintSupported;
	public VkBool32 costSupported;
	public VkBool32 bidirectionalFlowSupported;
	public VkBool32 globalFlowSupported;
	public uint32_t minWidth;
	public uint32_t minHeight;
	public uint32_t maxWidth;
	public uint32_t maxHeight;
	public uint32_t maxNumRegionsOfInterest;
}
public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t id;
	public uint32_t size;
	public void* pPrivateData;
}
public unsafe struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 legacyDithering;
}
public unsafe struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 pipelineProtectedAccess;
}
public unsafe struct VkTilePropertiesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkExtent3D tileSize;
	public VkExtent2D apronSize;
	public VkOffset2D origin;
}
public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 tileProperties;
}
public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 amigoProfiling;
}
public unsafe struct VkAmigoProfilingSubmitInfoSEC
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t firstDrawTimestamp;
	public uint64_t swapBufferTimestamp;
}
public unsafe struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 multiviewPerViewViewports;
}
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
}
public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 rayTracingInvocationReorder;
}
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 mutableDescriptorType;
}
public unsafe struct VkMutableDescriptorTypeListEXT
{
	public uint32_t descriptorTypeCount;
	public VkDescriptorType* pDescriptorTypes;
}
public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
{
	public VkStructureType sType;
	public void* pNext;
	public uint32_t mutableDescriptorTypeListCount;
	public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
}
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
{
	public VkStructureType sType;
	public void* pNext;
	public VkBool32 shaderCoreBuiltins;
}
public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
{
	public VkStructureType sType;
	public void* pNext;
	public uint64_t shaderCoreMask;
	public uint32_t shaderCoreCount;
	public uint32_t shaderWarpsPerCore;
}