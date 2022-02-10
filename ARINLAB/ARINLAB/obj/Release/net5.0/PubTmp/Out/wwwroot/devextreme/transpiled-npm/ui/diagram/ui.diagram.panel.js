"use strict";

exports.default = void 0;

var _renderer = _interopRequireDefault(require("../../core/renderer"));

var _ui = _interopRequireDefault(require("../widget/ui.widget"));

var _events_engine = _interopRequireDefault(require("../../events/core/events_engine"));

var _index = require("../../events/utils/index");

var _pointer = _interopRequireDefault(require("../../events/pointer"));

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _typeof(obj) { "@babel/helpers - typeof"; if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

function _get(target, property, receiver) { if (typeof Reflect !== "undefined" && Reflect.get) { _get = Reflect.get; } else { _get = function _get(target, property, receiver) { var base = _superPropBase(target, property); if (!base) return; var desc = Object.getOwnPropertyDescriptor(base, property); if (desc.get) { return desc.get.call(receiver); } return desc.value; }; } return _get(target, property, receiver || target); }

function _superPropBase(object, property) { while (!Object.prototype.hasOwnProperty.call(object, property)) { object = _getPrototypeOf(object); if (object === null) break; } return object; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); if (superClass) _setPrototypeOf(subClass, superClass); }

function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf || function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }

function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }

function _possibleConstructorReturn(self, call) { if (call && (_typeof(call) === "object" || typeof call === "function")) { return call; } return _assertThisInitialized(self); }

function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }

function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Date.prototype.toString.call(Reflect.construct(Date, [], function () {})); return true; } catch (e) { return false; } }

function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }

var POINTERUP_EVENT_NAME = (0, _index.addNamespace)(_pointer.default.up, 'dxDiagramPanel');
var PREVENT_REFOCUS_SELECTOR = '.dx-textbox';

var DiagramPanel = /*#__PURE__*/function (_Widget) {
  _inherits(DiagramPanel, _Widget);

  var _super = _createSuper(DiagramPanel);

  function DiagramPanel() {
    _classCallCheck(this, DiagramPanel);

    return _super.apply(this, arguments);
  }

  _createClass(DiagramPanel, [{
    key: "_init",
    value: function _init() {
      _get(_getPrototypeOf(DiagramPanel.prototype), "_init", this).call(this);

      this._createOnPointerUpAction();
    }
  }, {
    key: "_render",
    value: function _render() {
      _get(_getPrototypeOf(DiagramPanel.prototype), "_render", this).call(this);

      this._attachPointerUpEvent();
    }
  }, {
    key: "_getPointerUpElements",
    value: function _getPointerUpElements() {
      return [this.$element()];
    }
  }, {
    key: "_attachPointerUpEvent",
    value: function _attachPointerUpEvent() {
      var _this = this;

      var elements = this._getPointerUpElements();

      elements.forEach(function (element) {
        _events_engine.default.off(element, POINTERUP_EVENT_NAME);

        _events_engine.default.on(element, POINTERUP_EVENT_NAME, function (e) {
          if (!(0, _renderer.default)(e.target).closest(PREVENT_REFOCUS_SELECTOR).length) {
            _this._onPointerUpAction();
          }
        });
      });
    }
  }, {
    key: "_createOnPointerUpAction",
    value: function _createOnPointerUpAction() {
      this._onPointerUpAction = this._createActionByOption('onPointerUp');
    }
  }, {
    key: "_optionChanged",
    value: function _optionChanged(args) {
      switch (args.name) {
        case 'onPointerUp':
          this._createOnPointerUpAction();

          break;

        default:
          _get(_getPrototypeOf(DiagramPanel.prototype), "_optionChanged", this).call(this, args);

      }
    }
  }]);

  return DiagramPanel;
}(_ui.default);

var _default = DiagramPanel;
exports.default = _default;
module.exports = exports.default;