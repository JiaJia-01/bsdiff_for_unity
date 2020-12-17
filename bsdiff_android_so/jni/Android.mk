LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE := bsdiff
LOCAL_SRC_FILES := ../../bsdiff_source/bsdiff.c ../../bsdiff_source/bspatch.c

include $(BUILD_SHARED_LIBRARY)