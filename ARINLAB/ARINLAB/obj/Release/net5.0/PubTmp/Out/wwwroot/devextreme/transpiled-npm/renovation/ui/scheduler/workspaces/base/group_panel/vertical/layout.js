"use strict";

function _typeof(obj) { "@babel/helpers - typeof"; if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

exports.GroupPanelVerticalLayout = GroupPanelVerticalLayout;
exports.GroupPanelVerticalLayoutProps = exports.viewFunction = void 0;

var _row = require("./row");

var _utils = require("../../../utils");

var Preact = _interopRequireWildcard(require("preact"));

var _hooks = require("preact/hooks");

function _getRequireWildcardCache() { if (typeof WeakMap !== "function") return null; var cache = new WeakMap(); _getRequireWildcardCache = function _getRequireWildcardCache() { return cache; }; return cache; }

function _interopRequireWildcard(obj) { if (obj && obj.__esModule) { return obj; } if (obj === null || _typeof(obj) !== "object" && typeof obj !== "function") { return { default: obj }; } var cache = _getRequireWildcardCache(); if (cache && cache.has(obj)) { return cache.get(obj); } var newObj = {}; var hasPropertyDescriptor = Object.defineProperty && Object.getOwnPropertyDescriptor; for (var key in obj) { if (Object.prototype.hasOwnProperty.call(obj, key)) { var desc = hasPropertyDescriptor ? Object.getOwnPropertyDescriptor(obj, key) : null; if (desc && (desc.get || desc.set)) { Object.defineProperty(newObj, key, desc); } else { newObj[key] = obj[key]; } } } newObj.default = obj; if (cache) { cache.set(obj, newObj); } return newObj; }

function ownKeys(object, enumerableOnly) { var keys = Object.keys(object); if (Object.getOwnPropertySymbols) { var symbols = Object.getOwnPropertySymbols(object); if (enumerableOnly) symbols = symbols.filter(function (sym) { return Object.getOwnPropertyDescriptor(object, sym).enumerable; }); keys.push.apply(keys, symbols); } return keys; }

function _objectSpread(target) { for (var i = 1; i < arguments.length; i++) { var source = arguments[i] != null ? arguments[i] : {}; if (i % 2) { ownKeys(Object(source), true).forEach(function (key) { _defineProperty(target, key, source[key]); }); } else if (Object.getOwnPropertyDescriptors) { Object.defineProperties(target, Object.getOwnPropertyDescriptors(source)); } else { ownKeys(Object(source)).forEach(function (key) { Object.defineProperty(target, key, Object.getOwnPropertyDescriptor(source, key)); }); } } return target; }

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

function _objectWithoutProperties(source, excluded) { if (source == null) return {}; var target = _objectWithoutPropertiesLoose(source, excluded); var key, i; if (Object.getOwnPropertySymbols) { var sourceSymbolKeys = Object.getOwnPropertySymbols(source); for (i = 0; i < sourceSymbolKeys.length; i++) { key = sourceSymbolKeys[i]; if (excluded.indexOf(key) >= 0) continue; if (!Object.prototype.propertyIsEnumerable.call(source, key)) continue; target[key] = source[key]; } } return target; }

function _objectWithoutPropertiesLoose(source, excluded) { if (source == null) return {}; var target = {}; var sourceKeys = Object.keys(source); var key, i; for (i = 0; i < sourceKeys.length; i++) { key = sourceKeys[i]; if (excluded.indexOf(key) >= 0) continue; target[key] = source[key]; } return target; }

function _extends() { _extends = Object.assign || function (target) { for (var i = 1; i < arguments.length; i++) { var source = arguments[i]; for (var key in source) { if (Object.prototype.hasOwnProperty.call(source, key)) { target[key] = source[key]; } } } return target; }; return _extends.apply(this, arguments); }

function _toConsumableArray(arr) { return _arrayWithoutHoles(arr) || _iterableToArray(arr) || _unsupportedIterableToArray(arr) || _nonIterableSpread(); }

function _nonIterableSpread() { throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method."); }

function _unsupportedIterableToArray(o, minLen) { if (!o) return; if (typeof o === "string") return _arrayLikeToArray(o, minLen); var n = Object.prototype.toString.call(o).slice(8, -1); if (n === "Object" && o.constructor) n = o.constructor.name; if (n === "Map" || n === "Set") return Array.from(o); if (n === "Arguments" || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n)) return _arrayLikeToArray(o, minLen); }

function _iterableToArray(iter) { if (typeof Symbol !== "undefined" && Symbol.iterator in Object(iter)) return Array.from(iter); }

function _arrayWithoutHoles(arr) { if (Array.isArray(arr)) return _arrayLikeToArray(arr); }

function _arrayLikeToArray(arr, len) { if (len == null || len > arr.length) len = arr.length; for (var i = 0, arr2 = new Array(len); i < len; i++) { arr2[i] = arr[i]; } return arr2; }

var getGroupsRenderData = function getGroupsRenderData(groups) {
  var repeatCount = 1;
  return groups.map(function (group) {
    var result = [];
    var data = group.data,
        items = group.items,
        resourceName = group.name;

    var _loop = function _loop(i) {
      result.push.apply(result, _toConsumableArray(items.map(function (_ref, index) {
        var color = _ref.color,
            id = _ref.id,
            text = _ref.text;
        return {
          id: id,
          text: text,
          color: color,
          key: "".concat(i, "_").concat(resourceName, "_").concat(id),
          resourceName: resourceName,
          data: data[index]
        };
      })));
    };

    for (var i = 0; i < repeatCount; i += 1) {
      _loop(i);
    }

    repeatCount *= items.length;
    return result;
  });
};

var viewFunction = function viewFunction(viewModel) {
  return Preact.h("div", _extends({
    className: "dx-scheduler-work-space-vertical-group-table ".concat(viewModel.props.className)
  }, viewModel.restAttributes, {
    style: viewModel.style
  }), Preact.h("div", {
    className: "dx-scheduler-group-flex-container"
  }, viewModel.groupsRenderData.map(function (group) {
    return Preact.h(_row.Row, {
      groupItems: group,
      cellTemplate: viewModel.props.cellTemplate,
      key: group[0].key
    });
  })));
};

exports.viewFunction = viewFunction;
var GroupPanelVerticalLayoutProps = {
  groups: [],
  className: ""
};
exports.GroupPanelVerticalLayoutProps = GroupPanelVerticalLayoutProps;

var getTemplate = function getTemplate(TemplateProp) {
  return TemplateProp && (TemplateProp.defaultProps ? function (props) {
    return Preact.h(TemplateProp, _extends({}, props));
  } : TemplateProp);
};

function GroupPanelVerticalLayout(props) {
  var __style = (0, _hooks.useCallback)(function __style() {
    var height = props.height;

    var _restAttributes = __restAttributes(),
        style = _restAttributes.style;

    return (0, _utils.addHeightToStyle)(height, style);
  }, [props.height]);

  var __groupsRenderData = (0, _hooks.useCallback)(function __groupsRenderData() {
    var groups = props.groups;
    return getGroupsRenderData(groups);
  }, [props.groups]);

  var __restAttributes = (0, _hooks.useCallback)(function __restAttributes() {
    var cellTemplate = props.cellTemplate,
        className = props.className,
        groups = props.groups,
        height = props.height,
        restProps = _objectWithoutProperties(props, ["cellTemplate", "className", "groups", "height"]);

    return restProps;
  }, [props]);

  return viewFunction({
    props: _objectSpread(_objectSpread({}, props), {}, {
      cellTemplate: getTemplate(props.cellTemplate)
    }),
    style: __style(),
    groupsRenderData: __groupsRenderData(),
    restAttributes: __restAttributes()
  });
}

GroupPanelVerticalLayout.defaultProps = _objectSpread({}, GroupPanelVerticalLayoutProps);