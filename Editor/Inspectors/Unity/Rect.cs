// ----------------------------------------------------------------------------
// The Proprietary or MIT-Red License
// Copyright (c) 2012-2022 Leopotam <leopotam@yandex.ru>
// ----------------------------------------------------------------------------

using UnityEditor;
using UnityEngine;

namespace Submodules.EcsLiteEditor {
    sealed class RectInspector : EcsComponentInspectorTyped<Rect> {
        public override bool OnGuiTyped (string label, ref Rect value, EcsEntityDebugView entityView) {
            var newValue = EditorGUILayout.RectField (label, value);
            if (newValue == value) { return false; }
            value = newValue;
            return true;
        }
    }
}