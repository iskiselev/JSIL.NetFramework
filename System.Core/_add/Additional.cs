using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions
{
    internal static class Error
    {
        internal static Exception ArgCntMustBeGreaterThanNameCnt()
        {
            return (Exception)new ArgumentException(Strings.ArgCntMustBeGreaterThanNameCnt);
        }

        internal static Exception ReducibleMustOverrideReduce()
        {
            return (Exception)new ArgumentException(Strings.ReducibleMustOverrideReduce);
        }

        internal static Exception MustReduceToDifferent()
        {
            return (Exception)new ArgumentException(Strings.MustReduceToDifferent);
        }

        internal static Exception ReducedNotCompatible()
        {
            return (Exception)new ArgumentException(Strings.ReducedNotCompatible);
        }

        internal static Exception SetterHasNoParams()
        {
            return (Exception)new ArgumentException(Strings.SetterHasNoParams);
        }

        internal static Exception PropertyCannotHaveRefType()
        {
            return (Exception)new ArgumentException(Strings.PropertyCannotHaveRefType);
        }

        internal static Exception IndexesOfSetGetMustMatch()
        {
            return (Exception)new ArgumentException(Strings.IndexesOfSetGetMustMatch);
        }

        internal static Exception AccessorsCannotHaveVarArgs()
        {
            return (Exception)new ArgumentException(Strings.AccessorsCannotHaveVarArgs);
        }

        internal static Exception AccessorsCannotHaveByRefArgs()
        {
            return (Exception)new ArgumentException(Strings.AccessorsCannotHaveByRefArgs);
        }

        internal static Exception BoundsCannotBeLessThanOne()
        {
            return (Exception)new ArgumentException(Strings.BoundsCannotBeLessThanOne);
        }

        internal static Exception TypeMustNotBeByRef()
        {
            return (Exception)new ArgumentException(Strings.TypeMustNotBeByRef);
        }

        internal static Exception TypeDoesNotHaveConstructorForTheSignature()
        {
            return (Exception)new ArgumentException(Strings.TypeDoesNotHaveConstructorForTheSignature);
        }

        internal static Exception CountCannotBeNegative()
        {
            return (Exception)new ArgumentException(Strings.CountCannotBeNegative);
        }

        internal static Exception ArrayTypeMustBeArray()
        {
            return (Exception)new ArgumentException(Strings.ArrayTypeMustBeArray);
        }

        internal static Exception SetterMustBeVoid()
        {
            return (Exception)new ArgumentException(Strings.SetterMustBeVoid);
        }

        internal static Exception PropertyTyepMustMatchSetter()
        {
            return (Exception)new ArgumentException(Strings.PropertyTyepMustMatchSetter);
        }

        internal static Exception BothAccessorsMustBeStatic()
        {
            return (Exception)new ArgumentException(Strings.BothAccessorsMustBeStatic);
        }

        internal static Exception OnlyStaticMethodsHaveNullInstance()
        {
            return (Exception)new ArgumentException(Strings.OnlyStaticMethodsHaveNullInstance);
        }

        internal static Exception PropertyTypeCannotBeVoid()
        {
            return (Exception)new ArgumentException(Strings.PropertyTypeCannotBeVoid);
        }

        internal static Exception InvalidUnboxType()
        {
            return (Exception)new ArgumentException(Strings.InvalidUnboxType);
        }

        internal static Exception ArgumentMustNotHaveValueType()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustNotHaveValueType);
        }

        internal static Exception MustBeReducible()
        {
            return (Exception)new ArgumentException(Strings.MustBeReducible);
        }

        internal static Exception DefaultBodyMustBeSupplied()
        {
            return (Exception)new ArgumentException(Strings.DefaultBodyMustBeSupplied);
        }

        internal static Exception MethodBuilderDoesNotHaveTypeBuilder()
        {
            return (Exception)new ArgumentException(Strings.MethodBuilderDoesNotHaveTypeBuilder);
        }

        internal static Exception TypeMustBeDerivedFromSystemDelegate()
        {
            return (Exception)new ArgumentException(Strings.TypeMustBeDerivedFromSystemDelegate);
        }

        internal static Exception ArgumentTypeCannotBeVoid()
        {
            return (Exception)new ArgumentException(Strings.ArgumentTypeCannotBeVoid);
        }

        internal static Exception LabelMustBeVoidOrHaveExpression()
        {
            return (Exception)new ArgumentException(Strings.LabelMustBeVoidOrHaveExpression);
        }

        internal static Exception LabelTypeMustBeVoid()
        {
            return (Exception)new ArgumentException(Strings.LabelTypeMustBeVoid);
        }

        internal static Exception QuotedExpressionMustBeLambda()
        {
            return (Exception)new ArgumentException(Strings.QuotedExpressionMustBeLambda);
        }

        internal static Exception VariableMustNotBeByRef(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.VariableMustNotBeByRef(p0, p1));
        }

        internal static Exception DuplicateVariable(object p0)
        {
            return (Exception)new ArgumentException(Strings.DuplicateVariable(p0));
        }

        internal static Exception StartEndMustBeOrdered()
        {
            return (Exception)new ArgumentException(Strings.StartEndMustBeOrdered);
        }

        internal static Exception FaultCannotHaveCatchOrFinally()
        {
            return (Exception)new ArgumentException(Strings.FaultCannotHaveCatchOrFinally);
        }

        internal static Exception TryMustHaveCatchFinallyOrFault()
        {
            return (Exception)new ArgumentException(Strings.TryMustHaveCatchFinallyOrFault);
        }

        internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry()
        {
            return (Exception)new ArgumentException(Strings.BodyOfCatchMustHaveSameTypeAsBodyOfTry);
        }

        internal static Exception ExtensionNodeMustOverrideProperty(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.ExtensionNodeMustOverrideProperty(p0));
        }

        internal static Exception UserDefinedOperatorMustBeStatic(object p0)
        {
            return (Exception)new ArgumentException(Strings.UserDefinedOperatorMustBeStatic(p0));
        }

        internal static Exception UserDefinedOperatorMustNotBeVoid(object p0)
        {
            return (Exception)new ArgumentException(Strings.UserDefinedOperatorMustNotBeVoid(p0));
        }

        internal static Exception CoercionOperatorNotDefined(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.CoercionOperatorNotDefined(p0, p1));
        }

        internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2)
        {
            return (Exception)new InvalidCastException(Strings.DynamicBinderResultNotAssignable(p0, p1, p2));
        }

        internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
        {
            return (Exception)new InvalidCastException(Strings.DynamicObjectResultNotAssignable(p0, p1, p2, p3));
        }

        internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.DynamicBindingNeedsRestrictions(p0, p1));
        }

        internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
        {
            return (Exception)new InvalidOperationException(Strings.BinderNotCompatibleWithCallSite(p0, p1, p2));
        }

        internal static Exception UnaryOperatorNotDefined(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.UnaryOperatorNotDefined(p0, p1));
        }

        internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2)
        {
            return (Exception)new InvalidOperationException(Strings.BinaryOperatorNotDefined(p0, p1, p2));
        }

        internal static Exception ReferenceEqualityNotDefined(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.ReferenceEqualityNotDefined(p0, p1));
        }

        internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.OperandTypesDoNotMatchParameters(p0, p1));
        }

        internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.OverloadOperatorTypeDoesNotMatchConversionType(p0, p1));
        }

        internal static Exception ConversionIsNotSupportedForArithmeticTypes()
        {
            return (Exception)new InvalidOperationException(Strings.ConversionIsNotSupportedForArithmeticTypes);
        }

        internal static Exception ArgumentMustBeArray()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeArray);
        }

        internal static Exception ArgumentMustBeBoolean()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeBoolean);
        }

        internal static Exception EqualityMustReturnBoolean(object p0)
        {
            return (Exception)new ArgumentException(Strings.EqualityMustReturnBoolean(p0));
        }

        internal static Exception ArgumentMustBeFieldInfoOrPropertInfo()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeFieldInfoOrPropertInfo);
        }

        internal static Exception ArgumentMustBeFieldInfoOrPropertInfoOrMethod()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeFieldInfoOrPropertInfoOrMethod);
        }

        internal static Exception ArgumentMustBeInstanceMember()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeInstanceMember);
        }

        internal static Exception ArgumentMustBeInteger()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeInteger);
        }

        internal static Exception ArgumentMustBeArrayIndexType()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeArrayIndexType);
        }

        internal static Exception ArgumentMustBeSingleDimensionalArrayType()
        {
            return (Exception)new ArgumentException(Strings.ArgumentMustBeSingleDimensionalArrayType);
        }

        internal static Exception ArgumentTypesMustMatch()
        {
            return (Exception)new ArgumentException(Strings.ArgumentTypesMustMatch);
        }

        internal static Exception CannotAutoInitializeValueTypeElementThroughProperty(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.CannotAutoInitializeValueTypeElementThroughProperty(p0));
        }

        internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.CannotAutoInitializeValueTypeMemberThroughProperty(p0));
        }

        internal static Exception IncorrectTypeForTypeAs(object p0)
        {
            return (Exception)new ArgumentException(Strings.IncorrectTypeForTypeAs(p0));
        }

        internal static Exception CoalesceUsedOnNonNullType()
        {
            return (Exception)new InvalidOperationException(Strings.CoalesceUsedOnNonNullType);
        }

        internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.ExpressionTypeCannotInitializeArrayType(p0, p1));
        }

        internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeDoesNotMatchConstructorParameter(p0, p1));
        }

        internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ArgumentTypeDoesNotMatchMember(p0, p1));
        }

        internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ArgumentMemberNotDeclOnType(p0, p1));
        }

        internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeDoesNotMatchMethodParameter(p0, p1, p2));
        }

        internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeDoesNotMatchParameter(p0, p1));
        }

        internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeDoesNotMatchReturn(p0, p1));
        }

        internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeDoesNotMatchAssignment(p0, p1));
        }

        internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeDoesNotMatchLabel(p0, p1));
        }

        internal static Exception ExpressionTypeNotInvocable(object p0)
        {
            return (Exception)new ArgumentException(Strings.ExpressionTypeNotInvocable(p0));
        }

        internal static Exception FieldNotDefinedForType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.FieldNotDefinedForType(p0, p1));
        }

        internal static Exception InstanceFieldNotDefinedForType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.InstanceFieldNotDefinedForType(p0, p1));
        }

        internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2)
        {
            return (Exception)new ArgumentException(Strings.FieldInfoNotDefinedForType(p0, p1, p2));
        }

        internal static Exception IncorrectNumberOfIndexes()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfIndexes);
        }

        internal static Exception IncorrectNumberOfLambdaArguments()
        {
            return (Exception)new InvalidOperationException(Strings.IncorrectNumberOfLambdaArguments);
        }

        internal static Exception IncorrectNumberOfLambdaDeclarationParameters()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfLambdaDeclarationParameters);
        }

        internal static Exception IncorrectNumberOfMethodCallArguments(object p0)
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfMethodCallArguments(p0));
        }

        internal static Exception IncorrectNumberOfConstructorArguments()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfConstructorArguments);
        }

        internal static Exception IncorrectNumberOfMembersForGivenConstructor()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfMembersForGivenConstructor);
        }

        internal static Exception IncorrectNumberOfArgumentsForMembers()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfArgumentsForMembers);
        }

        internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate()
        {
            return (Exception)new ArgumentException(Strings.LambdaTypeMustBeDerivedFromSystemDelegate);
        }

        internal static Exception MemberNotFieldOrProperty(object p0)
        {
            return (Exception)new ArgumentException(Strings.MemberNotFieldOrProperty(p0));
        }

        internal static Exception MethodContainsGenericParameters(object p0)
        {
            return (Exception)new ArgumentException(Strings.MethodContainsGenericParameters(p0));
        }

        internal static Exception MethodIsGeneric(object p0)
        {
            return (Exception)new ArgumentException(Strings.MethodIsGeneric(p0));
        }

        internal static Exception MethodNotPropertyAccessor(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.MethodNotPropertyAccessor(p0, p1));
        }

        internal static Exception PropertyDoesNotHaveGetter(object p0)
        {
            return (Exception)new ArgumentException(Strings.PropertyDoesNotHaveGetter(p0));
        }

        internal static Exception PropertyDoesNotHaveSetter(object p0)
        {
            return (Exception)new ArgumentException(Strings.PropertyDoesNotHaveSetter(p0));
        }

        internal static Exception PropertyDoesNotHaveAccessor(object p0)
        {
            return (Exception)new ArgumentException(Strings.PropertyDoesNotHaveAccessor(p0));
        }

        internal static Exception NotAMemberOfType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.NotAMemberOfType(p0, p1));
        }

        internal static Exception OperatorNotImplementedForType(object p0, object p1)
        {
            return (Exception)new NotImplementedException(Strings.OperatorNotImplementedForType(p0, p1));
        }

        internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ParameterExpressionNotValidAsDelegate(p0, p1));
        }

        internal static Exception PropertyNotDefinedForType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.PropertyNotDefinedForType(p0, p1));
        }

        internal static Exception InstancePropertyNotDefinedForType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.InstancePropertyNotDefinedForType(p0, p1));
        }

        internal static Exception InstancePropertyWithoutParameterNotDefinedForType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.InstancePropertyWithoutParameterNotDefinedForType(p0, p1));
        }

        internal static Exception InstancePropertyWithSpecifiedParametersNotDefinedForType(object p0, object p1, object p2)
        {
            return (Exception)new ArgumentException(Strings.InstancePropertyWithSpecifiedParametersNotDefinedForType(p0, p1, p2));
        }

        internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
        {
            return (Exception)new ArgumentException(Strings.InstanceAndMethodTypeMismatch(p0, p1, p2));
        }

        internal static Exception TypeContainsGenericParameters(object p0)
        {
            return (Exception)new ArgumentException(Strings.TypeContainsGenericParameters(p0));
        }

        internal static Exception TypeIsGeneric(object p0)
        {
            return (Exception)new ArgumentException(Strings.TypeIsGeneric(p0));
        }

        internal static Exception TypeMissingDefaultConstructor(object p0)
        {
            return (Exception)new ArgumentException(Strings.TypeMissingDefaultConstructor(p0));
        }

        internal static Exception ListInitializerWithZeroMembers()
        {
            return (Exception)new ArgumentException(Strings.ListInitializerWithZeroMembers);
        }

        internal static Exception ElementInitializerMethodNotAdd()
        {
            return (Exception)new ArgumentException(Strings.ElementInitializerMethodNotAdd);
        }

        internal static Exception ElementInitializerMethodNoRefOutParam(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.ElementInitializerMethodNoRefOutParam(p0, p1));
        }

        internal static Exception ElementInitializerMethodWithZeroArgs()
        {
            return (Exception)new ArgumentException(Strings.ElementInitializerMethodWithZeroArgs);
        }

        internal static Exception ElementInitializerMethodStatic()
        {
            return (Exception)new ArgumentException(Strings.ElementInitializerMethodStatic);
        }

        internal static Exception TypeNotIEnumerable(object p0)
        {
            return (Exception)new ArgumentException(Strings.TypeNotIEnumerable(p0));
        }

        internal static Exception TypeParameterIsNotDelegate(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.TypeParameterIsNotDelegate(p0));
        }

        internal static Exception UnexpectedCoalesceOperator()
        {
            return (Exception)new InvalidOperationException(Strings.UnexpectedCoalesceOperator);
        }

        internal static Exception InvalidCast(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.InvalidCast(p0, p1));
        }

        internal static Exception UnhandledBinary(object p0)
        {
            return (Exception)new ArgumentException(Strings.UnhandledBinary(p0));
        }

        internal static Exception UnhandledBinding()
        {
            return (Exception)new ArgumentException(Strings.UnhandledBinding);
        }

        internal static Exception UnhandledBindingType(object p0)
        {
            return (Exception)new ArgumentException(Strings.UnhandledBindingType(p0));
        }

        internal static Exception UnhandledConvert(object p0)
        {
            return (Exception)new ArgumentException(Strings.UnhandledConvert(p0));
        }

        internal static Exception UnhandledExpressionType(object p0)
        {
            return (Exception)new ArgumentException(Strings.UnhandledExpressionType(p0));
        }

        internal static Exception UnhandledUnary(object p0)
        {
            return (Exception)new ArgumentException(Strings.UnhandledUnary(p0));
        }

        internal static Exception UnknownBindingType()
        {
            return (Exception)new ArgumentException(Strings.UnknownBindingType);
        }

        internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.UserDefinedOpMustHaveConsistentTypes(p0, p1));
        }

        internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.UserDefinedOpMustHaveValidReturnType(p0, p1));
        }

        internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.LogicalOperatorMustHaveBooleanOperators(p0, p1));
        }

        internal static Exception MethodDoesNotExistOnType(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.MethodDoesNotExistOnType(p0, p1));
        }

        internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.MethodWithArgsDoesNotExistOnType(p0, p1));
        }

        internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.GenericMethodWithArgsDoesNotExistOnType(p0, p1));
        }

        internal static Exception MethodWithMoreThanOneMatch(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.MethodWithMoreThanOneMatch(p0, p1));
        }

        internal static Exception PropertyWithMoreThanOneMatch(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.PropertyWithMoreThanOneMatch(p0, p1));
        }

        internal static Exception IncorrectNumberOfTypeArgsForFunc()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfTypeArgsForFunc);
        }

        internal static Exception IncorrectNumberOfTypeArgsForAction()
        {
            return (Exception)new ArgumentException(Strings.IncorrectNumberOfTypeArgsForAction);
        }

        internal static Exception ArgumentCannotBeOfTypeVoid()
        {
            return (Exception)new ArgumentException(Strings.ArgumentCannotBeOfTypeVoid);
        }

        internal static Exception AmbiguousMatchInExpandoObject(object p0)
        {
            return (Exception)new AmbiguousMatchException(Strings.AmbiguousMatchInExpandoObject(p0));
        }

        internal static Exception SameKeyExistsInExpando(object p0)
        {
            return (Exception)new ArgumentException(Strings.SameKeyExistsInExpando(p0));
        }

        internal static Exception KeyDoesNotExistInExpando(object p0)
        {
            return (Exception)new KeyNotFoundException(Strings.KeyDoesNotExistInExpando(p0));
        }

        internal static Exception NoOrInvalidRuleProduced()
        {
            return (Exception)new InvalidOperationException(Strings.NoOrInvalidRuleProduced);
        }

        internal static Exception FirstArgumentMustBeCallSite()
        {
            return (Exception)new ArgumentException(Strings.FirstArgumentMustBeCallSite);
        }

        internal static Exception BindingCannotBeNull()
        {
            return (Exception)new InvalidOperationException(Strings.BindingCannotBeNull);
        }

        internal static Exception InvalidOperation(object p0)
        {
            return (Exception)new ArgumentException(Strings.InvalidOperation(p0));
        }

        internal static Exception OutOfRange(object p0, object p1)
        {
            return (Exception)new ArgumentOutOfRangeException(Strings.OutOfRange(p0, p1));
        }

        internal static Exception QueueEmpty()
        {
            return (Exception)new InvalidOperationException(Strings.QueueEmpty);
        }

        internal static Exception LabelTargetAlreadyDefined(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.LabelTargetAlreadyDefined(p0));
        }

        internal static Exception LabelTargetUndefined(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.LabelTargetUndefined(p0));
        }

        internal static Exception ControlCannotLeaveFinally()
        {
            return (Exception)new InvalidOperationException(Strings.ControlCannotLeaveFinally);
        }

        internal static Exception ControlCannotLeaveFilterTest()
        {
            return (Exception)new InvalidOperationException(Strings.ControlCannotLeaveFilterTest);
        }

        internal static Exception AmbiguousJump(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.AmbiguousJump(p0));
        }

        internal static Exception ControlCannotEnterTry()
        {
            return (Exception)new InvalidOperationException(Strings.ControlCannotEnterTry);
        }

        internal static Exception ControlCannotEnterExpression()
        {
            return (Exception)new InvalidOperationException(Strings.ControlCannotEnterExpression);
        }

        internal static Exception NonLocalJumpWithValue(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.NonLocalJumpWithValue(p0));
        }

        internal static Exception ExtensionNotReduced()
        {
            return (Exception)new InvalidOperationException(Strings.ExtensionNotReduced);
        }

        internal static Exception CannotCompileConstant(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.CannotCompileConstant(p0));
        }

        internal static Exception CannotCompileDynamic()
        {
            return (Exception)new NotSupportedException(Strings.CannotCompileDynamic);
        }

        internal static Exception InvalidLvalue(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.InvalidLvalue(p0));
        }

        internal static Exception InvalidMemberType(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.InvalidMemberType(p0));
        }

        internal static Exception UnknownLiftType(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.UnknownLiftType(p0));
        }

        internal static Exception InvalidOutputDir()
        {
            return (Exception)new ArgumentException(Strings.InvalidOutputDir);
        }

        internal static Exception InvalidAsmNameOrExtension()
        {
            return (Exception)new ArgumentException(Strings.InvalidAsmNameOrExtension);
        }

        internal static Exception CollectionReadOnly()
        {
            return (Exception)new NotSupportedException(Strings.CollectionReadOnly);
        }

        internal static Exception IllegalNewGenericParams(object p0)
        {
            return (Exception)new ArgumentException(Strings.IllegalNewGenericParams(p0));
        }

        internal static Exception UndefinedVariable(object p0, object p1, object p2)
        {
            return (Exception)new InvalidOperationException(Strings.UndefinedVariable(p0, p1, p2));
        }

        internal static Exception CannotCloseOverByRef(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.CannotCloseOverByRef(p0, p1));
        }

        internal static Exception UnexpectedVarArgsCall(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.UnexpectedVarArgsCall(p0));
        }

        internal static Exception RethrowRequiresCatch()
        {
            return (Exception)new InvalidOperationException(Strings.RethrowRequiresCatch);
        }

        internal static Exception TryNotAllowedInFilter()
        {
            return (Exception)new InvalidOperationException(Strings.TryNotAllowedInFilter);
        }

        internal static Exception MustRewriteToSameNode(object p0, object p1, object p2)
        {
            return (Exception)new InvalidOperationException(Strings.MustRewriteToSameNode(p0, p1, p2));
        }

        internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2)
        {
            return (Exception)new InvalidOperationException(Strings.MustRewriteChildToSameType(p0, p1, p2));
        }

        internal static Exception MustRewriteWithoutMethod(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.MustRewriteWithoutMethod(p0, p1));
        }

        internal static Exception TryNotSupportedForMethodsWithRefArgs(object p0)
        {
            return (Exception)new NotSupportedException(Strings.TryNotSupportedForMethodsWithRefArgs(p0));
        }

        internal static Exception TryNotSupportedForValueTypeInstances(object p0)
        {
            return (Exception)new NotSupportedException(Strings.TryNotSupportedForValueTypeInstances(p0));
        }

        internal static Exception CollectionModifiedWhileEnumerating()
        {
            return (Exception)new InvalidOperationException(Strings.CollectionModifiedWhileEnumerating);
        }

        internal static Exception EnumerationIsDone()
        {
            return (Exception)new InvalidOperationException(Strings.EnumerationIsDone);
        }

        internal static Exception HomogenousAppDomainRequired()
        {
            return (Exception)new InvalidOperationException(Strings.HomogenousAppDomainRequired);
        }

        internal static Exception TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.TestValueTypeDoesNotMatchComparisonMethodParameter(p0, p1));
        }

        internal static Exception SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
        {
            return (Exception)new ArgumentException(Strings.SwitchValueTypeDoesNotMatchComparisonMethodParameter(p0, p1));
        }

        internal static Exception InvalidMetaObjectCreated(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.InvalidMetaObjectCreated(p0));
        }

        internal static Exception PdbGeneratorNeedsExpressionCompiler()
        {
            return (Exception)new NotSupportedException(Strings.PdbGeneratorNeedsExpressionCompiler);
        }

        internal static Exception ArgumentNull(string paramName)
        {
            return (Exception)new ArgumentNullException(paramName);
        }

        internal static Exception ArgumentOutOfRange(string paramName)
        {
            return (Exception)new ArgumentOutOfRangeException(paramName);
        }

        internal static Exception NotImplemented()
        {
            return (Exception)new NotImplementedException();
        }

        internal static Exception NotSupported()
        {
            return (Exception)new NotSupportedException();
        }
    }
}
// Decompiled with JetBrains decompiler
// Type: System.Linq.Expressions.Strings
// Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: D8F48900-3DB7-498B-B156-BCD39786DA13
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll

namespace System.Linq.Expressions
{
    internal static class Strings
    {
        internal static string MethodPreconditionViolated
        {
            get
            {
                return SR.GetString("MethodPreconditionViolated");
            }
        }

        internal static string InvalidArgumentValue
        {
            get
            {
                return SR.GetString("InvalidArgumentValue");
            }
        }

        internal static string NonEmptyCollectionRequired
        {
            get
            {
                return SR.GetString("NonEmptyCollectionRequired");
            }
        }

        internal static string ArgCntMustBeGreaterThanNameCnt
        {
            get
            {
                return SR.GetString("ArgCntMustBeGreaterThanNameCnt");
            }
        }

        internal static string ReducibleMustOverrideReduce
        {
            get
            {
                return SR.GetString("ReducibleMustOverrideReduce");
            }
        }

        internal static string MustReduceToDifferent
        {
            get
            {
                return SR.GetString("MustReduceToDifferent");
            }
        }

        internal static string ReducedNotCompatible
        {
            get
            {
                return SR.GetString("ReducedNotCompatible");
            }
        }

        internal static string SetterHasNoParams
        {
            get
            {
                return SR.GetString("SetterHasNoParams");
            }
        }

        internal static string PropertyCannotHaveRefType
        {
            get
            {
                return SR.GetString("PropertyCannotHaveRefType");
            }
        }

        internal static string IndexesOfSetGetMustMatch
        {
            get
            {
                return SR.GetString("IndexesOfSetGetMustMatch");
            }
        }

        internal static string AccessorsCannotHaveVarArgs
        {
            get
            {
                return SR.GetString("AccessorsCannotHaveVarArgs");
            }
        }

        internal static string AccessorsCannotHaveByRefArgs
        {
            get
            {
                return SR.GetString("AccessorsCannotHaveByRefArgs");
            }
        }

        internal static string BoundsCannotBeLessThanOne
        {
            get
            {
                return SR.GetString("BoundsCannotBeLessThanOne");
            }
        }

        internal static string TypeMustNotBeByRef
        {
            get
            {
                return SR.GetString("TypeMustNotBeByRef");
            }
        }

        internal static string TypeDoesNotHaveConstructorForTheSignature
        {
            get
            {
                return SR.GetString("TypeDoesNotHaveConstructorForTheSignature");
            }
        }

        internal static string CountCannotBeNegative
        {
            get
            {
                return SR.GetString("CountCannotBeNegative");
            }
        }

        internal static string ArrayTypeMustBeArray
        {
            get
            {
                return SR.GetString("ArrayTypeMustBeArray");
            }
        }

        internal static string SetterMustBeVoid
        {
            get
            {
                return SR.GetString("SetterMustBeVoid");
            }
        }

        internal static string PropertyTyepMustMatchSetter
        {
            get
            {
                return SR.GetString("PropertyTyepMustMatchSetter");
            }
        }

        internal static string BothAccessorsMustBeStatic
        {
            get
            {
                return SR.GetString("BothAccessorsMustBeStatic");
            }
        }

        internal static string OnlyStaticFieldsHaveNullInstance
        {
            get
            {
                return SR.GetString("OnlyStaticFieldsHaveNullInstance");
            }
        }

        internal static string OnlyStaticPropertiesHaveNullInstance
        {
            get
            {
                return SR.GetString("OnlyStaticPropertiesHaveNullInstance");
            }
        }

        internal static string OnlyStaticMethodsHaveNullInstance
        {
            get
            {
                return SR.GetString("OnlyStaticMethodsHaveNullInstance");
            }
        }

        internal static string PropertyTypeCannotBeVoid
        {
            get
            {
                return SR.GetString("PropertyTypeCannotBeVoid");
            }
        }

        internal static string InvalidUnboxType
        {
            get
            {
                return SR.GetString("InvalidUnboxType");
            }
        }

        internal static string ExpressionMustBeReadable
        {
            get
            {
                return SR.GetString("ExpressionMustBeReadable");
            }
        }

        internal static string ExpressionMustBeWriteable
        {
            get
            {
                return SR.GetString("ExpressionMustBeWriteable");
            }
        }

        internal static string ArgumentMustNotHaveValueType
        {
            get
            {
                return SR.GetString("ArgumentMustNotHaveValueType");
            }
        }

        internal static string MustBeReducible
        {
            get
            {
                return SR.GetString("MustBeReducible");
            }
        }

        internal static string AllTestValuesMustHaveSameType
        {
            get
            {
                return SR.GetString("AllTestValuesMustHaveSameType");
            }
        }

        internal static string AllCaseBodiesMustHaveSameType
        {
            get
            {
                return SR.GetString("AllCaseBodiesMustHaveSameType");
            }
        }

        internal static string DefaultBodyMustBeSupplied
        {
            get
            {
                return SR.GetString("DefaultBodyMustBeSupplied");
            }
        }

        internal static string MethodBuilderDoesNotHaveTypeBuilder
        {
            get
            {
                return SR.GetString("MethodBuilderDoesNotHaveTypeBuilder");
            }
        }

        internal static string TypeMustBeDerivedFromSystemDelegate
        {
            get
            {
                return SR.GetString("TypeMustBeDerivedFromSystemDelegate");
            }
        }

        internal static string ArgumentTypeCannotBeVoid
        {
            get
            {
                return SR.GetString("ArgumentTypeCannotBeVoid");
            }
        }

        internal static string LabelMustBeVoidOrHaveExpression
        {
            get
            {
                return SR.GetString("LabelMustBeVoidOrHaveExpression");
            }
        }

        internal static string LabelTypeMustBeVoid
        {
            get
            {
                return SR.GetString("LabelTypeMustBeVoid");
            }
        }

        internal static string QuotedExpressionMustBeLambda
        {
            get
            {
                return SR.GetString("QuotedExpressionMustBeLambda");
            }
        }

        internal static string StartEndMustBeOrdered
        {
            get
            {
                return SR.GetString("StartEndMustBeOrdered");
            }
        }

        internal static string FaultCannotHaveCatchOrFinally
        {
            get
            {
                return SR.GetString("FaultCannotHaveCatchOrFinally");
            }
        }

        internal static string TryMustHaveCatchFinallyOrFault
        {
            get
            {
                return SR.GetString("TryMustHaveCatchFinallyOrFault");
            }
        }

        internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry
        {
            get
            {
                return SR.GetString("BodyOfCatchMustHaveSameTypeAsBodyOfTry");
            }
        }

        internal static string ConversionIsNotSupportedForArithmeticTypes
        {
            get
            {
                return SR.GetString("ConversionIsNotSupportedForArithmeticTypes");
            }
        }

        internal static string ArgumentMustBeArray
        {
            get
            {
                return SR.GetString("ArgumentMustBeArray");
            }
        }

        internal static string ArgumentMustBeBoolean
        {
            get
            {
                return SR.GetString("ArgumentMustBeBoolean");
            }
        }

        internal static string ArgumentMustBeFieldInfoOrPropertInfo
        {
            get
            {
                return SR.GetString("ArgumentMustBeFieldInfoOrPropertInfo");
            }
        }

        internal static string ArgumentMustBeFieldInfoOrPropertInfoOrMethod
        {
            get
            {
                return SR.GetString("ArgumentMustBeFieldInfoOrPropertInfoOrMethod");
            }
        }

        internal static string ArgumentMustBeInstanceMember
        {
            get
            {
                return SR.GetString("ArgumentMustBeInstanceMember");
            }
        }

        internal static string ArgumentMustBeInteger
        {
            get
            {
                return SR.GetString("ArgumentMustBeInteger");
            }
        }

        internal static string ArgumentMustBeArrayIndexType
        {
            get
            {
                return SR.GetString("ArgumentMustBeArrayIndexType");
            }
        }

        internal static string ArgumentMustBeSingleDimensionalArrayType
        {
            get
            {
                return SR.GetString("ArgumentMustBeSingleDimensionalArrayType");
            }
        }

        internal static string ArgumentTypesMustMatch
        {
            get
            {
                return SR.GetString("ArgumentTypesMustMatch");
            }
        }

        internal static string CoalesceUsedOnNonNullType
        {
            get
            {
                return SR.GetString("CoalesceUsedOnNonNullType");
            }
        }

        internal static string IncorrectNumberOfIndexes
        {
            get
            {
                return SR.GetString("IncorrectNumberOfIndexes");
            }
        }

        internal static string IncorrectNumberOfLambdaArguments
        {
            get
            {
                return SR.GetString("IncorrectNumberOfLambdaArguments");
            }
        }

        internal static string IncorrectNumberOfLambdaDeclarationParameters
        {
            get
            {
                return SR.GetString("IncorrectNumberOfLambdaDeclarationParameters");
            }
        }

        internal static string IncorrectNumberOfConstructorArguments
        {
            get
            {
                return SR.GetString("IncorrectNumberOfConstructorArguments");
            }
        }

        internal static string IncorrectNumberOfMembersForGivenConstructor
        {
            get
            {
                return SR.GetString("IncorrectNumberOfMembersForGivenConstructor");
            }
        }

        internal static string IncorrectNumberOfArgumentsForMembers
        {
            get
            {
                return SR.GetString("IncorrectNumberOfArgumentsForMembers");
            }
        }

        internal static string LambdaTypeMustBeDerivedFromSystemDelegate
        {
            get
            {
                return SR.GetString("LambdaTypeMustBeDerivedFromSystemDelegate");
            }
        }

        internal static string ListInitializerWithZeroMembers
        {
            get
            {
                return SR.GetString("ListInitializerWithZeroMembers");
            }
        }

        internal static string ElementInitializerMethodNotAdd
        {
            get
            {
                return SR.GetString("ElementInitializerMethodNotAdd");
            }
        }

        internal static string ElementInitializerMethodWithZeroArgs
        {
            get
            {
                return SR.GetString("ElementInitializerMethodWithZeroArgs");
            }
        }

        internal static string ElementInitializerMethodStatic
        {
            get
            {
                return SR.GetString("ElementInitializerMethodStatic");
            }
        }

        internal static string UnexpectedCoalesceOperator
        {
            get
            {
                return SR.GetString("UnexpectedCoalesceOperator");
            }
        }

        internal static string UnhandledBinding
        {
            get
            {
                return SR.GetString("UnhandledBinding");
            }
        }

        internal static string UnknownBindingType
        {
            get
            {
                return SR.GetString("UnknownBindingType");
            }
        }

        internal static string IncorrectNumberOfTypeArgsForFunc
        {
            get
            {
                return SR.GetString("IncorrectNumberOfTypeArgsForFunc");
            }
        }

        internal static string IncorrectNumberOfTypeArgsForAction
        {
            get
            {
                return SR.GetString("IncorrectNumberOfTypeArgsForAction");
            }
        }

        internal static string ArgumentCannotBeOfTypeVoid
        {
            get
            {
                return SR.GetString("ArgumentCannotBeOfTypeVoid");
            }
        }

        internal static string NoOrInvalidRuleProduced
        {
            get
            {
                return SR.GetString("NoOrInvalidRuleProduced");
            }
        }

        internal static string FirstArgumentMustBeCallSite
        {
            get
            {
                return SR.GetString("FirstArgumentMustBeCallSite");
            }
        }

        internal static string BindingCannotBeNull
        {
            get
            {
                return SR.GetString("BindingCannotBeNull");
            }
        }

        internal static string QueueEmpty
        {
            get
            {
                return SR.GetString("QueueEmpty");
            }
        }

        internal static string ControlCannotLeaveFinally
        {
            get
            {
                return SR.GetString("ControlCannotLeaveFinally");
            }
        }

        internal static string ControlCannotLeaveFilterTest
        {
            get
            {
                return SR.GetString("ControlCannotLeaveFilterTest");
            }
        }

        internal static string ControlCannotEnterTry
        {
            get
            {
                return SR.GetString("ControlCannotEnterTry");
            }
        }

        internal static string ControlCannotEnterExpression
        {
            get
            {
                return SR.GetString("ControlCannotEnterExpression");
            }
        }

        internal static string ExtensionNotReduced
        {
            get
            {
                return SR.GetString("ExtensionNotReduced");
            }
        }

        internal static string CannotCompileDynamic
        {
            get
            {
                return SR.GetString("CannotCompileDynamic");
            }
        }

        internal static string InvalidOutputDir
        {
            get
            {
                return SR.GetString("InvalidOutputDir");
            }
        }

        internal static string InvalidAsmNameOrExtension
        {
            get
            {
                return SR.GetString("InvalidAsmNameOrExtension");
            }
        }

        internal static string CollectionReadOnly
        {
            get
            {
                return SR.GetString("CollectionReadOnly");
            }
        }

        internal static string RethrowRequiresCatch
        {
            get
            {
                return SR.GetString("RethrowRequiresCatch");
            }
        }

        internal static string TryNotAllowedInFilter
        {
            get
            {
                return SR.GetString("TryNotAllowedInFilter");
            }
        }

        internal static string CollectionModifiedWhileEnumerating
        {
            get
            {
                return SR.GetString("CollectionModifiedWhileEnumerating");
            }
        }

        internal static string EnumerationIsDone
        {
            get
            {
                return SR.GetString("EnumerationIsDone");
            }
        }

        internal static string HomogenousAppDomainRequired
        {
            get
            {
                return SR.GetString("HomogenousAppDomainRequired");
            }
        }

        internal static string PdbGeneratorNeedsExpressionCompiler
        {
            get
            {
                return SR.GetString("PdbGeneratorNeedsExpressionCompiler");
            }
        }

        internal static string VariableMustNotBeByRef(object p0, object p1)
        {
            return SR.GetString("VariableMustNotBeByRef", p0, p1);
        }

        internal static string DuplicateVariable(object p0)
        {
            return SR.GetString("DuplicateVariable", new object[1]
            {
        p0
            });
        }

        internal static string ExtensionNodeMustOverrideProperty(object p0)
        {
            return SR.GetString("ExtensionNodeMustOverrideProperty", new object[1]
            {
        p0
            });
        }

        internal static string UserDefinedOperatorMustBeStatic(object p0)
        {
            return SR.GetString("UserDefinedOperatorMustBeStatic", new object[1]
            {
        p0
            });
        }

        internal static string UserDefinedOperatorMustNotBeVoid(object p0)
        {
            return SR.GetString("UserDefinedOperatorMustNotBeVoid", new object[1]
            {
        p0
            });
        }

        internal static string CoercionOperatorNotDefined(object p0, object p1)
        {
            return SR.GetString("CoercionOperatorNotDefined", p0, p1);
        }

        internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2)
        {
            return SR.GetString("DynamicBinderResultNotAssignable", p0, p1, p2);
        }

        internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
        {
            return SR.GetString("DynamicObjectResultNotAssignable", p0, p1, p2, p3);
        }

        internal static string DynamicBindingNeedsRestrictions(object p0, object p1)
        {
            return SR.GetString("DynamicBindingNeedsRestrictions", p0, p1);
        }

        internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
        {
            return SR.GetString("BinderNotCompatibleWithCallSite", p0, p1, p2);
        }

        internal static string UnaryOperatorNotDefined(object p0, object p1)
        {
            return SR.GetString("UnaryOperatorNotDefined", p0, p1);
        }

        internal static string BinaryOperatorNotDefined(object p0, object p1, object p2)
        {
            return SR.GetString("BinaryOperatorNotDefined", p0, p1, p2);
        }

        internal static string ReferenceEqualityNotDefined(object p0, object p1)
        {
            return SR.GetString("ReferenceEqualityNotDefined", p0, p1);
        }

        internal static string OperandTypesDoNotMatchParameters(object p0, object p1)
        {
            return SR.GetString("OperandTypesDoNotMatchParameters", p0, p1);
        }

        internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
        {
            return SR.GetString("OverloadOperatorTypeDoesNotMatchConversionType", p0, p1);
        }

        internal static string EqualityMustReturnBoolean(object p0)
        {
            return SR.GetString("EqualityMustReturnBoolean", new object[1]
            {
        p0
            });
        }

        internal static string CannotAutoInitializeValueTypeElementThroughProperty(object p0)
        {
            return SR.GetString("CannotAutoInitializeValueTypeElementThroughProperty", new object[1]
            {
        p0
            });
        }

        internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
        {
            return SR.GetString("CannotAutoInitializeValueTypeMemberThroughProperty", new object[1]
            {
        p0
            });
        }

        internal static string IncorrectTypeForTypeAs(object p0)
        {
            return SR.GetString("IncorrectTypeForTypeAs", new object[1]
            {
        p0
            });
        }

        internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1)
        {
            return SR.GetString("ExpressionTypeCannotInitializeArrayType", p0, p1);
        }

        internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1)
        {
            return SR.GetString("ExpressionTypeDoesNotMatchConstructorParameter", p0, p1);
        }

        internal static string ArgumentTypeDoesNotMatchMember(object p0, object p1)
        {
            return SR.GetString("ArgumentTypeDoesNotMatchMember", p0, p1);
        }

        internal static string ArgumentMemberNotDeclOnType(object p0, object p1)
        {
            return SR.GetString("ArgumentMemberNotDeclOnType", p0, p1);
        }

        internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2)
        {
            return SR.GetString("ExpressionTypeDoesNotMatchMethodParameter", p0, p1, p2);
        }

        internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1)
        {
            return SR.GetString("ExpressionTypeDoesNotMatchParameter", p0, p1);
        }

        internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1)
        {
            return SR.GetString("ExpressionTypeDoesNotMatchReturn", p0, p1);
        }

        internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
        {
            return SR.GetString("ExpressionTypeDoesNotMatchAssignment", p0, p1);
        }

        internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1)
        {
            return SR.GetString("ExpressionTypeDoesNotMatchLabel", p0, p1);
        }

        internal static string ExpressionTypeNotInvocable(object p0)
        {
            return SR.GetString("ExpressionTypeNotInvocable", new object[1]
            {
        p0
            });
        }

        internal static string FieldNotDefinedForType(object p0, object p1)
        {
            return SR.GetString("FieldNotDefinedForType", p0, p1);
        }

        internal static string InstanceFieldNotDefinedForType(object p0, object p1)
        {
            return SR.GetString("InstanceFieldNotDefinedForType", p0, p1);
        }

        internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2)
        {
            return SR.GetString("FieldInfoNotDefinedForType", p0, p1, p2);
        }

        internal static string IncorrectNumberOfMethodCallArguments(object p0)
        {
            return SR.GetString("IncorrectNumberOfMethodCallArguments", new object[1]
            {
        p0
            });
        }

        internal static string MemberNotFieldOrProperty(object p0)
        {
            return SR.GetString("MemberNotFieldOrProperty", new object[1]
            {
        p0
            });
        }

        internal static string MethodContainsGenericParameters(object p0)
        {
            return SR.GetString("MethodContainsGenericParameters", new object[1]
            {
        p0
            });
        }

        internal static string MethodIsGeneric(object p0)
        {
            return SR.GetString("MethodIsGeneric", new object[1]
            {
        p0
            });
        }

        internal static string MethodNotPropertyAccessor(object p0, object p1)
        {
            return SR.GetString("MethodNotPropertyAccessor", p0, p1);
        }

        internal static string PropertyDoesNotHaveGetter(object p0)
        {
            return SR.GetString("PropertyDoesNotHaveGetter", new object[1]
            {
        p0
            });
        }

        internal static string PropertyDoesNotHaveSetter(object p0)
        {
            return SR.GetString("PropertyDoesNotHaveSetter", new object[1]
            {
        p0
            });
        }

        internal static string PropertyDoesNotHaveAccessor(object p0)
        {
            return SR.GetString("PropertyDoesNotHaveAccessor", new object[1]
            {
        p0
            });
        }

        internal static string NotAMemberOfType(object p0, object p1)
        {
            return SR.GetString("NotAMemberOfType", p0, p1);
        }

        internal static string OperatorNotImplementedForType(object p0, object p1)
        {
            return SR.GetString("OperatorNotImplementedForType", p0, p1);
        }

        internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1)
        {
            return SR.GetString("ParameterExpressionNotValidAsDelegate", p0, p1);
        }

        internal static string PropertyNotDefinedForType(object p0, object p1)
        {
            return SR.GetString("PropertyNotDefinedForType", p0, p1);
        }

        internal static string InstancePropertyNotDefinedForType(object p0, object p1)
        {
            return SR.GetString("InstancePropertyNotDefinedForType", p0, p1);
        }

        internal static string InstancePropertyWithoutParameterNotDefinedForType(object p0, object p1)
        {
            return SR.GetString("InstancePropertyWithoutParameterNotDefinedForType", p0, p1);
        }

        internal static string InstancePropertyWithSpecifiedParametersNotDefinedForType(object p0, object p1, object p2)
        {
            return SR.GetString("InstancePropertyWithSpecifiedParametersNotDefinedForType", p0, p1, p2);
        }

        internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
        {
            return SR.GetString("InstanceAndMethodTypeMismatch", p0, p1, p2);
        }

        internal static string TypeContainsGenericParameters(object p0)
        {
            return SR.GetString("TypeContainsGenericParameters", new object[1]
            {
        p0
            });
        }

        internal static string TypeIsGeneric(object p0)
        {
            return SR.GetString("TypeIsGeneric", new object[1]
            {
        p0
            });
        }

        internal static string TypeMissingDefaultConstructor(object p0)
        {
            return SR.GetString("TypeMissingDefaultConstructor", new object[1]
            {
        p0
            });
        }

        internal static string ElementInitializerMethodNoRefOutParam(object p0, object p1)
        {
            return SR.GetString("ElementInitializerMethodNoRefOutParam", p0, p1);
        }

        internal static string TypeNotIEnumerable(object p0)
        {
            return SR.GetString("TypeNotIEnumerable", new object[1]
            {
        p0
            });
        }

        internal static string TypeParameterIsNotDelegate(object p0)
        {
            return SR.GetString("TypeParameterIsNotDelegate", new object[1]
            {
        p0
            });
        }

        internal static string InvalidCast(object p0, object p1)
        {
            return SR.GetString("InvalidCast", p0, p1);
        }

        internal static string UnhandledBinary(object p0)
        {
            return SR.GetString("UnhandledBinary", new object[1]
            {
        p0
            });
        }

        internal static string UnhandledBindingType(object p0)
        {
            return SR.GetString("UnhandledBindingType", new object[1]
            {
        p0
            });
        }

        internal static string UnhandledConvert(object p0)
        {
            return SR.GetString("UnhandledConvert", new object[1]
            {
        p0
            });
        }

        internal static string UnhandledExpressionType(object p0)
        {
            return SR.GetString("UnhandledExpressionType", new object[1]
            {
        p0
            });
        }

        internal static string UnhandledUnary(object p0)
        {
            return SR.GetString("UnhandledUnary", new object[1]
            {
        p0
            });
        }

        internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
        {
            return SR.GetString("UserDefinedOpMustHaveConsistentTypes", p0, p1);
        }

        internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1)
        {
            return SR.GetString("UserDefinedOpMustHaveValidReturnType", p0, p1);
        }

        internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
        {
            return SR.GetString("LogicalOperatorMustHaveBooleanOperators", p0, p1);
        }

        internal static string MethodDoesNotExistOnType(object p0, object p1)
        {
            return SR.GetString("MethodDoesNotExistOnType", p0, p1);
        }

        internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1)
        {
            return SR.GetString("MethodWithArgsDoesNotExistOnType", p0, p1);
        }

        internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
        {
            return SR.GetString("GenericMethodWithArgsDoesNotExistOnType", p0, p1);
        }

        internal static string MethodWithMoreThanOneMatch(object p0, object p1)
        {
            return SR.GetString("MethodWithMoreThanOneMatch", p0, p1);
        }

        internal static string PropertyWithMoreThanOneMatch(object p0, object p1)
        {
            return SR.GetString("PropertyWithMoreThanOneMatch", p0, p1);
        }

        internal static string AmbiguousMatchInExpandoObject(object p0)
        {
            return SR.GetString("AmbiguousMatchInExpandoObject", new object[1]
            {
        p0
            });
        }

        internal static string SameKeyExistsInExpando(object p0)
        {
            return SR.GetString("SameKeyExistsInExpando", new object[1]
            {
        p0
            });
        }

        internal static string KeyDoesNotExistInExpando(object p0)
        {
            return SR.GetString("KeyDoesNotExistInExpando", new object[1]
            {
        p0
            });
        }

        internal static string InvalidOperation(object p0)
        {
            return SR.GetString("InvalidOperation", new object[1]
            {
        p0
            });
        }

        internal static string OutOfRange(object p0, object p1)
        {
            return SR.GetString("OutOfRange", p0, p1);
        }

        internal static string LabelTargetAlreadyDefined(object p0)
        {
            return SR.GetString("LabelTargetAlreadyDefined", new object[1]
            {
        p0
            });
        }

        internal static string LabelTargetUndefined(object p0)
        {
            return SR.GetString("LabelTargetUndefined", new object[1]
            {
        p0
            });
        }

        internal static string AmbiguousJump(object p0)
        {
            return SR.GetString("AmbiguousJump", new object[1]
            {
        p0
            });
        }

        internal static string NonLocalJumpWithValue(object p0)
        {
            return SR.GetString("NonLocalJumpWithValue", new object[1]
            {
        p0
            });
        }

        internal static string CannotCompileConstant(object p0)
        {
            return SR.GetString("CannotCompileConstant", new object[1]
            {
        p0
            });
        }

        internal static string InvalidLvalue(object p0)
        {
            return SR.GetString("InvalidLvalue", new object[1]
            {
        p0
            });
        }

        internal static string InvalidMemberType(object p0)
        {
            return SR.GetString("InvalidMemberType", new object[1]
            {
        p0
            });
        }

        internal static string UnknownLiftType(object p0)
        {
            return SR.GetString("UnknownLiftType", new object[1]
            {
        p0
            });
        }

        internal static string IllegalNewGenericParams(object p0)
        {
            return SR.GetString("IllegalNewGenericParams", new object[1]
            {
        p0
            });
        }

        internal static string UndefinedVariable(object p0, object p1, object p2)
        {
            return SR.GetString("UndefinedVariable", p0, p1, p2);
        }

        internal static string CannotCloseOverByRef(object p0, object p1)
        {
            return SR.GetString("CannotCloseOverByRef", p0, p1);
        }

        internal static string UnexpectedVarArgsCall(object p0)
        {
            return SR.GetString("UnexpectedVarArgsCall", new object[1]
            {
        p0
            });
        }

        internal static string MustRewriteToSameNode(object p0, object p1, object p2)
        {
            return SR.GetString("MustRewriteToSameNode", p0, p1, p2);
        }

        internal static string MustRewriteChildToSameType(object p0, object p1, object p2)
        {
            return SR.GetString("MustRewriteChildToSameType", p0, p1, p2);
        }

        internal static string MustRewriteWithoutMethod(object p0, object p1)
        {
            return SR.GetString("MustRewriteWithoutMethod", p0, p1);
        }

        internal static string InvalidNullValue(object p0)
        {
            return SR.GetString("InvalidNullValue", new object[1]
            {
        p0
            });
        }

        internal static string InvalidObjectType(object p0, object p1)
        {
            return SR.GetString("InvalidObjectType", p0, p1);
        }

        internal static string TryNotSupportedForMethodsWithRefArgs(object p0)
        {
            return SR.GetString("TryNotSupportedForMethodsWithRefArgs", new object[1]
            {
        p0
            });
        }

        internal static string TryNotSupportedForValueTypeInstances(object p0)
        {
            return SR.GetString("TryNotSupportedForValueTypeInstances", new object[1]
            {
        p0
            });
        }

        internal static string TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
        {
            return SR.GetString("TestValueTypeDoesNotMatchComparisonMethodParameter", p0, p1);
        }

        internal static string SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
        {
            return SR.GetString("SwitchValueTypeDoesNotMatchComparisonMethodParameter", p0, p1);
        }

        internal static string InvalidMetaObjectCreated(object p0)
        {
            return SR.GetString("InvalidMetaObjectCreated", new object[1]
            {
        p0
            });
        }
    }
}

namespace System.Linq
{
    internal static class Error
    {
        internal static Exception ArgumentArrayHasTooManyElements(object p0)
        {
            return (Exception)new ArgumentException(Strings.ArgumentArrayHasTooManyElements(p0));
        }

        internal static Exception ArgumentNotIEnumerableGeneric(object p0)
        {
            return (Exception)new ArgumentException(Strings.ArgumentNotIEnumerableGeneric(p0));
        }

        internal static Exception ArgumentNotSequence(object p0)
        {
            return (Exception)new ArgumentException(Strings.ArgumentNotSequence(p0));
        }

        internal static Exception ArgumentNotValid(object p0)
        {
            return (Exception)new ArgumentException(Strings.ArgumentNotValid(p0));
        }

        internal static Exception IncompatibleElementTypes()
        {
            return (Exception)new ArgumentException(Strings.IncompatibleElementTypes);
        }

        internal static Exception ArgumentNotLambda(object p0)
        {
            return (Exception)new ArgumentException(Strings.ArgumentNotLambda(p0));
        }

        internal static Exception MoreThanOneElement()
        {
            return (Exception)new InvalidOperationException(Strings.MoreThanOneElement);
        }

        internal static Exception MoreThanOneMatch()
        {
            return (Exception)new InvalidOperationException(Strings.MoreThanOneMatch);
        }

        internal static Exception NoArgumentMatchingMethodsInQueryable(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.NoArgumentMatchingMethodsInQueryable(p0));
        }

        internal static Exception NoElements()
        {
            return (Exception)new InvalidOperationException(Strings.NoElements);
        }

        internal static Exception NoMatch()
        {
            return (Exception)new InvalidOperationException(Strings.NoMatch);
        }

        internal static Exception NoMethodOnType(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.NoMethodOnType(p0, p1));
        }

        internal static Exception NoMethodOnTypeMatchingArguments(object p0, object p1)
        {
            return (Exception)new InvalidOperationException(Strings.NoMethodOnTypeMatchingArguments(p0, p1));
        }

        internal static Exception NoNameMatchingMethodsInQueryable(object p0)
        {
            return (Exception)new InvalidOperationException(Strings.NoNameMatchingMethodsInQueryable(p0));
        }

        internal static Exception ArgumentNull(string paramName)
        {
            return (Exception)new ArgumentNullException(paramName);
        }

        internal static Exception ArgumentOutOfRange(string paramName)
        {
            return (Exception)new ArgumentOutOfRangeException(paramName);
        }

        internal static Exception NotImplemented()
        {
            return (Exception)new NotImplementedException();
        }

        internal static Exception NotSupported()
        {
            return (Exception)new NotSupportedException();
        }
    }
}
namespace System.Linq
{
    internal static class Strings
    {
        internal static string OwningTeam
        {
            get
            {
                return SR.GetString("OwningTeam");
            }
        }

        internal static string IncompatibleElementTypes
        {
            get
            {
                return SR.GetString("IncompatibleElementTypes");
            }
        }

        internal static string MoreThanOneElement
        {
            get
            {
                return SR.GetString("MoreThanOneElement");
            }
        }

        internal static string MoreThanOneMatch
        {
            get
            {
                return SR.GetString("MoreThanOneMatch");
            }
        }

        internal static string NoElements
        {
            get
            {
                return SR.GetString("NoElements");
            }
        }

        internal static string NoMatch
        {
            get
            {
                return SR.GetString("NoMatch");
            }
        }

        internal static string EmptyEnumerable
        {
            get
            {
                return SR.GetString("EmptyEnumerable");
            }
        }

        internal static string Argument_AdjustmentRulesNoNulls
        {
            get
            {
                return SR.GetString("Argument_AdjustmentRulesNoNulls");
            }
        }

        internal static string Argument_AdjustmentRulesOutOfOrder
        {
            get
            {
                return SR.GetString("Argument_AdjustmentRulesOutOfOrder");
            }
        }

        internal static string Argument_AdjustmentRulesAmbiguousOverlap
        {
            get
            {
                return SR.GetString("Argument_AdjustmentRulesAmbiguousOverlap");
            }
        }

        internal static string Argument_AdjustmentRulesrDaylightSavingTimeOverlap
        {
            get
            {
                return SR.GetString("Argument_AdjustmentRulesrDaylightSavingTimeOverlap");
            }
        }

        internal static string Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange
        {
            get
            {
                return SR.GetString("Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange");
            }
        }

        internal static string Argument_AdjustmentRulesInvalidOverlap
        {
            get
            {
                return SR.GetString("Argument_AdjustmentRulesInvalidOverlap");
            }
        }

        internal static string Argument_ConvertMismatch
        {
            get
            {
                return SR.GetString("Argument_ConvertMismatch");
            }
        }

        internal static string Argument_DateTimeHasTimeOfDay
        {
            get
            {
                return SR.GetString("Argument_DateTimeHasTimeOfDay");
            }
        }

        internal static string Argument_DateTimeIsInvalid
        {
            get
            {
                return SR.GetString("Argument_DateTimeIsInvalid");
            }
        }

        internal static string Argument_DateTimeIsNotAmbiguous
        {
            get
            {
                return SR.GetString("Argument_DateTimeIsNotAmbiguous");
            }
        }

        internal static string Argument_DateTimeOffsetIsNotAmbiguous
        {
            get
            {
                return SR.GetString("Argument_DateTimeOffsetIsNotAmbiguous");
            }
        }

        internal static string Argument_DateTimeKindMustBeUnspecified
        {
            get
            {
                return SR.GetString("Argument_DateTimeKindMustBeUnspecified");
            }
        }

        internal static string Argument_DateTimeHasTicks
        {
            get
            {
                return SR.GetString("Argument_DateTimeHasTicks");
            }
        }

        internal static string Argument_InvalidREG_TZI_FORMAT
        {
            get
            {
                return SR.GetString("Argument_InvalidREG_TZI_FORMAT");
            }
        }

        internal static string Argument_OutOfOrderDateTimes
        {
            get
            {
                return SR.GetString("Argument_OutOfOrderDateTimes");
            }
        }

        internal static string Argument_TimeSpanHasSeconds
        {
            get
            {
                return SR.GetString("Argument_TimeSpanHasSeconds");
            }
        }

        internal static string Argument_TimeZoneInfoBadTZif
        {
            get
            {
                return SR.GetString("Argument_TimeZoneInfoBadTZif");
            }
        }

        internal static string Argument_TimeZoneInfoInvalidTZif
        {
            get
            {
                return SR.GetString("Argument_TimeZoneInfoInvalidTZif");
            }
        }

        internal static string Argument_TransitionTimesAreIdentical
        {
            get
            {
                return SR.GetString("Argument_TransitionTimesAreIdentical");
            }
        }

        internal static string ArgumentOutOfRange_DayParam
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_DayParam");
            }
        }

        internal static string ArgumentOutOfRange_DayOfWeek
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_DayOfWeek");
            }
        }

        internal static string ArgumentOutOfRange_MonthParam
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_MonthParam");
            }
        }

        internal static string ArgumentOutOfRange_UtcOffset
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_UtcOffset");
            }
        }

        internal static string ArgumentOutOfRange_UtcOffsetAndDaylightDelta
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_UtcOffsetAndDaylightDelta");
            }
        }

        internal static string ArgumentOutOfRange_Week
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_Week");
            }
        }

        internal static string InvalidTimeZone_InvalidWin32APIData
        {
            get
            {
                return SR.GetString("InvalidTimeZone_InvalidWin32APIData");
            }
        }

        internal static string ArgumentOutOfRange_DateTimeBadTicks
        {
            get
            {
                return SR.GetString("ArgumentOutOfRange_DateTimeBadTicks");
            }
        }

        internal static string PLINQ_CommonEnumerator_Current_NotStarted
        {
            get
            {
                return SR.GetString("PLINQ_CommonEnumerator_Current_NotStarted");
            }
        }

        internal static string PLINQ_ExternalCancellationRequested
        {
            get
            {
                return SR.GetString("PLINQ_ExternalCancellationRequested");
            }
        }

        internal static string PLINQ_DisposeRequested
        {
            get
            {
                return SR.GetString("PLINQ_DisposeRequested");
            }
        }

        internal static string PLINQ_EnumerationPreviouslyFailed
        {
            get
            {
                return SR.GetString("PLINQ_EnumerationPreviouslyFailed");
            }
        }

        internal static string ParallelPartitionable_NullReturn
        {
            get
            {
                return SR.GetString("ParallelPartitionable_NullReturn");
            }
        }

        internal static string ParallelPartitionable_NullElement
        {
            get
            {
                return SR.GetString("ParallelPartitionable_NullElement");
            }
        }

        internal static string ParallelPartitionable_IncorretElementCount
        {
            get
            {
                return SR.GetString("ParallelPartitionable_IncorretElementCount");
            }
        }

        internal static string ParallelEnumerable_ToArray_DimensionRequired
        {
            get
            {
                return SR.GetString("ParallelEnumerable_ToArray_DimensionRequired");
            }
        }

        internal static string ParallelEnumerable_WithQueryExecutionMode_InvalidMode
        {
            get
            {
                return SR.GetString("ParallelEnumerable_WithQueryExecutionMode_InvalidMode");
            }
        }

        internal static string ParallelEnumerable_WithMergeOptions_InvalidOptions
        {
            get
            {
                return SR.GetString("ParallelEnumerable_WithMergeOptions_InvalidOptions");
            }
        }

        internal static string ParallelEnumerable_BinaryOpMustUseAsParallel
        {
            get
            {
                return SR.GetString("ParallelEnumerable_BinaryOpMustUseAsParallel");
            }
        }

        internal static string ParallelEnumerable_WithCancellation_TokenSourceDisposed
        {
            get
            {
                return SR.GetString("ParallelEnumerable_WithCancellation_TokenSourceDisposed");
            }
        }

        internal static string ParallelQuery_InvalidAsOrderedCall
        {
            get
            {
                return SR.GetString("ParallelQuery_InvalidAsOrderedCall");
            }
        }

        internal static string ParallelQuery_InvalidNonGenericAsOrderedCall
        {
            get
            {
                return SR.GetString("ParallelQuery_InvalidNonGenericAsOrderedCall");
            }
        }

        internal static string ParallelQuery_PartitionerNotOrderable
        {
            get
            {
                return SR.GetString("ParallelQuery_PartitionerNotOrderable");
            }
        }

        internal static string ParallelQuery_DuplicateTaskScheduler
        {
            get
            {
                return SR.GetString("ParallelQuery_DuplicateTaskScheduler");
            }
        }

        internal static string ParallelQuery_DuplicateDOP
        {
            get
            {
                return SR.GetString("ParallelQuery_DuplicateDOP");
            }
        }

        internal static string ParallelQuery_DuplicateWithCancellation
        {
            get
            {
                return SR.GetString("ParallelQuery_DuplicateWithCancellation");
            }
        }

        internal static string ParallelQuery_DuplicateExecutionMode
        {
            get
            {
                return SR.GetString("ParallelQuery_DuplicateExecutionMode");
            }
        }

        internal static string ParallelQuery_DuplicateMergeOptions
        {
            get
            {
                return SR.GetString("ParallelQuery_DuplicateMergeOptions");
            }
        }

        internal static string PartitionerQueryOperator_NullPartitionList
        {
            get
            {
                return SR.GetString("PartitionerQueryOperator_NullPartitionList");
            }
        }

        internal static string PartitionerQueryOperator_WrongNumberOfPartitions
        {
            get
            {
                return SR.GetString("PartitionerQueryOperator_WrongNumberOfPartitions");
            }
        }

        internal static string PartitionerQueryOperator_NullPartition
        {
            get
            {
                return SR.GetString("PartitionerQueryOperator_NullPartition");
            }
        }

        internal static string ArgumentArrayHasTooManyElements(object p0)
        {
            return SR.GetString("ArgumentArrayHasTooManyElements", new object[1]
            {
        p0
            });
        }

        internal static string ArgumentNotIEnumerableGeneric(object p0)
        {
            return SR.GetString("ArgumentNotIEnumerableGeneric", new object[1]
            {
        p0
            });
        }

        internal static string ArgumentNotSequence(object p0)
        {
            return SR.GetString("ArgumentNotSequence", new object[1]
            {
        p0
            });
        }

        internal static string ArgumentNotValid(object p0)
        {
            return SR.GetString("ArgumentNotValid", new object[1]
            {
        p0
            });
        }

        internal static string ArgumentNotLambda(object p0)
        {
            return SR.GetString("ArgumentNotLambda", new object[1]
            {
        p0
            });
        }

        internal static string NoArgumentMatchingMethodsInQueryable(object p0)
        {
            return SR.GetString("NoArgumentMatchingMethodsInQueryable", new object[1]
            {
        p0
            });
        }

        internal static string NoMethodOnType(object p0, object p1)
        {
            return SR.GetString("NoMethodOnType", p0, p1);
        }

        internal static string NoMethodOnTypeMatchingArguments(object p0, object p1)
        {
            return SR.GetString("NoMethodOnTypeMatchingArguments", p0, p1);
        }

        internal static string NoNameMatchingMethodsInQueryable(object p0)
        {
            return SR.GetString("NoNameMatchingMethodsInQueryable", new object[1]
            {
        p0
            });
        }

        internal static string Argument_InvalidId(object p0)
        {
            return SR.GetString("Argument_InvalidId", new object[1]
            {
        p0
            });
        }

        internal static string Argument_InvalidSerializedString(object p0)
        {
            return SR.GetString("Argument_InvalidSerializedString", new object[1]
            {
        p0
            });
        }

        internal static string InvalidTimeZone_InvalidRegistryData(object p0)
        {
            return SR.GetString("InvalidTimeZone_InvalidRegistryData", new object[1]
            {
        p0
            });
        }

        internal static string Security_CannotReadRegistryData(object p0)
        {
            return SR.GetString("Security_CannotReadRegistryData", new object[1]
            {
        p0
            });
        }

        internal static string Serialization_CorruptField(object p0)
        {
            return SR.GetString("Serialization_CorruptField", new object[1]
            {
        p0
            });
        }

        internal static string Serialization_InvalidEscapeSequence(object p0)
        {
            return SR.GetString("Serialization_InvalidEscapeSequence", new object[1]
            {
        p0
            });
        }

        internal static string TimeZoneNotFound_MissingRegistryData(object p0)
        {
            return SR.GetString("TimeZoneNotFound_MissingRegistryData", new object[1]
            {
        p0
            });
        }

        internal static string event_ParallelQueryBegin(object p0, object p1, object p2)
        {
            return SR.GetString("event_ParallelQueryBegin", p0, p1, p2);
        }

        internal static string event_ParallelQueryEnd(object p0, object p1, object p2)
        {
            return SR.GetString("event_ParallelQueryEnd", p0, p1, p2);
        }

        internal static string event_ParallelQueryFork(object p0, object p1, object p2)
        {
            return SR.GetString("event_ParallelQueryFork", p0, p1, p2);
        }

        internal static string event_ParallelQueryJoin(object p0, object p1, object p2)
        {
            return SR.GetString("event_ParallelQueryJoin", p0, p1, p2);
        }
    }
}