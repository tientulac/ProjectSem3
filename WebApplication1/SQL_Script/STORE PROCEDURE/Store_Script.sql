USE [NGO_Website]
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEvent_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UserEvent_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UserEvent_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEvent_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UserEvent_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UserEvent_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus_Post]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateStatus_Post]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UpdateStatus_Post]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus_Event]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateStatus_Event]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UpdateStatus_Event]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus_Donor]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateStatus_Donor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UpdateStatus_Donor]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMoney_Participant]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateMoney_Participant]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UpdateMoney_Participant]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMoney_Category]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateMoney_Category]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UpdateMoney_Category]
GO
/****** Object:  StoredProcedure [dbo].[sp_Update_Slot]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Update_Slot]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Update_Slot]
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_SupportType_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_SupportType_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_SupportType_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_SupportType_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_SupportType_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_SupportType_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_SupportType_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_SupportType_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PostType_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_PostType_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PostType_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_PostType_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PostType_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_PostType_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PostType_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_PostType_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Post_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Post_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Post_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Post_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Post_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Post_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Post_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Post_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantPost_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantPost_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantPost_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantPost_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantPost_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantPost_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantPost_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantPost_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantPost_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantEvent_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantEvent_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantEvent_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantEvent_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantEvent_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantEvent_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantEvent_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantEvent_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantEvent_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantCommunity_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantCommunity_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantCommunity_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantCommunity_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantCommunity_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantCommunity_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantCommunity_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ParticipantCommunity_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ParticipantCommunity_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Participant_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Participant_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Participant_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Participant_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Participant_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Participant_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Participant_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Participant_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MoneyType_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_MoneyType_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MoneyType_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_MoneyType_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MoneyType_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_MoneyType_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MoneyType_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_MoneyType_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerPost_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerPost_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerPost_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerPost_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerPost_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerPost_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerPost_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerPost_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerPost_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerEvent_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerEvent_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerEvent_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerEvent_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerEvent_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerEvent_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerEvent_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerEvent_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerEvent_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerCommunity_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerCommunity_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerCommunity_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerCommunity_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerCommunity_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerCommunity_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerCommunity_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ManagerCommunity_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ManagerCommunity_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Manager_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Manager_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Manager_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Manager_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Manager_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Manager_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Manager_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Manager_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Local_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Local_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Local_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Local_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Local_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Local_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Local_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Local_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsersunction_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsersunction_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsersunction_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Login]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_Login]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_Login]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUsers_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUsers_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUserFunction_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUserFunction_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUserFunction_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_htUserFunction_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htUserFunction_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htUserFunction_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htFunctions_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htFunctions_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htFunctions_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htFunctions_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htFunctions_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htFunctions_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htFunctions_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htFunctions_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunction_Load_User]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_htFunction_Load_User]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_htFunction_Load_User]
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Event_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Event_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Event_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Event_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Event_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Event_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Event_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Event_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Donor_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Donor_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Donor_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Donor_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Donor_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Donor_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Donor_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_Donor_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CommunityDonate_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CommunityDonate_Update]
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CommunityDonate_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CommunityDonate_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CommunityDonate_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CommunityDonate_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CommunityDonate_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CommunityDonate_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_UPDATE]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CharityFund_UPDATE]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CharityFund_UPDATE]
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CharityFund_Load_List]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CharityFund_Load_List]
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CharityFund_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CharityFund_Insert]
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_CharityFund_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_CharityFund_Delete]
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CharityFund_Delete]
	@FundId INT
AS
	DELETE FROM CharityFund WHERE FundId = @FundId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE 
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CharityFund_Insert]
	@FundName NVARCHAR(MAX),
	@TotalAmount DECIMAL,
	@SupportTypeId INT,
	@Image NVARCHAR(MAX)

AS
	INSERT INTO CharityFund(FundName,TotalAmount,SupportTypeId,Image)
		VALUES(@FundName,@TotalAmount,@SupportTypeId,@Image)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CharityFund_Load_List]
AS
SELECT CharityFund.*,SupportType.SupportTypeName FROM CharityFund
	INNER JOIN SupportType ON  CharityFund.SupportTypeId = SupportType.SupportTypeId
GO
/****** Object:  StoredProcedure [dbo].[sp_CharityFund_UPDATE]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CharityFund_UPDATE]
	@FundName NVARCHAR(MAX),
	@TotalAmount DECIMAL,
	@SupportTypeId INT,
	@Image NVARCHAR(MAX),
	@FundId INT
AS
	UPDATE CharityFund SET 
	FundName = @FundName,
	TotalAmount = @TotalAmount,
	SupportTypeId = @SupportTypeId,
	Image = @Image
	WHERE FundId = @FundId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE 
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CommunityDonate_Delete]
	@CommunityId INT
AS
	DELETE FROM	CommunityDonate WHERE CommunityId = @CommunityId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CommunityDonate_Insert]
	@CommunityName NVARCHAR(MAX),
	@Description NVARCHAR(MAX),
	@Url NVARCHAR(MAX),
	@Slot INT,
	@ToTalAmount DECIMAL,
	@SupportTypeId INT,
	@LocalId INT,
	@Image NVARCHAR(MAX),
	@Title NVARCHAR(MAX)
AS
	INSERT INTO CommunityDonate(CommunityName,Description,Url,Slot,TotalAmount,SupportTypeId,LocalId,Image,Title)
	VALUES(@CommunityName,@Description,@Url,@Slot,@ToTalAmount,@SupportTypeId,@LocalId,@Image,@Title)
SELECT @@IDENTITY AS 'Identity'


GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CommunityDonate_Load_List]
AS
	SELECT com.*,type.SupportTypeName,Local.LocalName
	FROM CommunityDonate com
	INNER JOIN SupportType type ON com.SupportTypeId = type.SupportTypeId
	INNER JOIN Local ON com.LocalId = Local.LocalId
GO
/****** Object:  StoredProcedure [dbo].[sp_CommunityDonate_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CommunityDonate_Update]
	@CommunityName NVARCHAR(MAX),
	@Description NVARCHAR(MAX),
	@Url NVARCHAR(MAX),
	@Slot INT,
	@ToTalAmount DECIMAL,
	@SupportTypeId INT,
	@LocalId INT,
	@Image NVARCHAR(MAX),
	@Title NVARCHAR(MAX),
	@CommunityId INT
AS
	UPDATE CommunityDonate SET 
	CommunityName = @CommunityName,
	Description = @Description,
	Url = @Url,
	Slot = @Slot,
	TotalAmount = @ToTalAmount,
	SupportTypeId = @SupportTypeId,
	LocalId = @LocalId,
	Image = @Image,
	Title = @Title
	WHERE CommunityId = @CommunityId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Donor_Delete]
	@DonorId INT
AS
	DELETE FROM	Donor WHERE DonorId = @DonorId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Donor_Insert]
	@DonorName NVARCHAR(MAX),
	@Address NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Phone NVARCHAR(50),
	@ToTalAmount DECIMAL,
	@Status INT,
	@SupportTypeId INT,
	@LocalId INT,
	@Image NVARCHAR(MAX),
	@Title NVARCHAR(MAX)
AS
	INSERT INTO Donor(DonorName,Address,Email,Phone,ToTalAmount,Status,SupportTypeId,LocalId,Image,Title)
	VALUES(@DonorName,@Address,@Email,@Phone,@ToTalAmount,@Status,@SupportTypeId,@LocalId,@Image,@Title)
SELECT @@IDENTITY AS 'Identity'


GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Donor_Load_List]
AS
	SELECT Donor.*,type.SupportTypeName,Local.LocalName
	FROM Donor 
	LEFT JOIN SupportType type ON Donor.SupportTypeId = type.SupportTypeId
	LEFT JOIN Local ON Donor.LocalId = Local.LocalId
GO
/****** Object:  StoredProcedure [dbo].[sp_Donor_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Donor_Update]
	@DonorName NVARCHAR(MAX),
	@Address NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Phone NVARCHAR(50),
	@ToTalAmount DECIMAL,
	@Status INT,
	@SupportTypeId INT,
	@LocalId INT,
	@Image NVARCHAR(MAX),
	@Title NVARCHAR(MAX),
	@DonorId INT
AS
	UPDATE Donor SET 
	DonorName = @DonorName,
	Address = @Address,
	Email = @Email,
	Phone = @Phone,
	TotalAmount = @ToTalAmount,
	Status = @Status,
	SupportTypeId = @SupportTypeId,
	Image = @Image,
	Title = @Title,
	LocalId = @LocalId
	WHERE DonorId = @DonorId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Event_Delete]
	@EventId INT
AS
	DELETE FROM	Event WHERE EventId = @EventId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Event_Insert] 
	@EventName NVARCHAR(MAX),
	@FromDate DATETIME,
	@ToDate DATETIME,
	@Content NVARCHAR(MAX),
	@Slot INT,
	@DesiredAmount DECIMAL,
	@DonateAmount DECIMAL,
	@SupportTypeId INT,
	@LocalId INT,
	@Status INT,
	@Image NVARCHAR(MAX),
	@Title NVARCHAR(MAX)
AS
	INSERT INTO Event(EventName,FromDate,ToDate,Content,Slot,DesiredAmount,DonateAmount,SupportTypeId,LocalId,Status,Image,Title)
	VALUES(@EventName,@FromDate,@ToDate,@Content,@Slot,@DesiredAmount,@DonateAmount,@SupportTypeId,@LocalId,@Status,@Image,@Title)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Event_Load_List]
AS
	SELECT Event.*,type.SupportTypeName,Local.LocalName
	FROM Event 
	LEFT JOIN SupportType type ON Event.SupportTypeId = type.SupportTypeId
	LEFT JOIN Local ON Event.LocalId = Local.LocalId
GO
/****** Object:  StoredProcedure [dbo].[sp_Event_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Event_Update]
	@EventName NVARCHAR(MAX),
	@FromDate DATETIME,
	@ToDate DATETIME,
	@Content NVARCHAR(MAX),
	@Slot INT,
	@DesiredAmount DECIMAL,
	@DonateAmount DECIMAL,
	@SupportTypeId INT,
	@LocalId INT,
	@Status INT,
	@EventId INT,
	@Image NVARCHAR(MAX),
	@Title NVARCHAR(MAX)
AS
	UPDATE Event SET 
	EventName = @EventName,
	FromDate = @FromDate,
	ToDate = @ToDate,
	Content = @Content,
	Slot = @Slot,
	DesiredAmount = @DesiredAmount,
	DonateAmount = @DonateAmount,
	SupportTypeId = @SupportTypeId,
	LocalId = @LocalId,
	Status = @Status,
	Image = @Image,
	Title = @Title
	WHERE EventId = @EventId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunction_Load_User]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htFunction_Load_User]
@UserId	int
AS
SELECT * FROM htFunctions a
WHERE a.FuntionId IN(SELECT FunctionId FROM htUserFunction WHERE UserId = @UserId)
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_htFunctions_Delete]
	@FunctionId INT
AS
	DELETE FROM htFunctions WHERE FuntionId = @FunctionId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_htFunctions_Insert]
	@FunctionCode NVARCHAR(50),
	@FunctionName NVARCHAR(200)
AS
	INSERT INTO htFunctions(FunctionCode,FunctionName)
		VALUES(@FunctionCode,@FunctionName)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_htFunctions_Load_List]
AS
SELECT * FROM htFunctions
GO
/****** Object:  StoredProcedure [dbo].[sp_htFunctions_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_htFunctions_Update]
	@FunctionCode NVARCHAR(50),
	@FunctionName NVARCHAR(200),
	@FunctionId INT
AS
	UPDATE htFunctions SET FunctionCode = @FunctionCode, FunctionName = @FunctionName WHERE FuntionId = @FunctionId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_htUserFunction_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUserFunction_Delete]
	@UserId  int
AS
DELETE FROM htUserFunction
WHERE (UserId = @UserId)

IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
Else
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_htUserFunction_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUserFunction_Insert]
	@UserId  int,
	@FunctionId  int
AS
INSERT INTO htUserFunction (
	UserId, 
	FunctionId)
VALUES(
	@UserId, 
	@FunctionId)
SELECT 1 AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUsers_Delete]
	@UserID  int
AS
DELETE FROM htUsers
WHERE (UserID = @UserID)

IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
Else
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUsers_Insert]
	@UserName  nvarchar(50),
	@PassWord  nvarchar(50),
	@FullName  nvarchar(50),
	@Admin  bit,
	@Active  bit,
	@Email nvarchar(100),
	@UserCategory INT
AS
INSERT INTO htUsers (
	UserName, 
	PassWord, 
	FullName, 
	Admin, 
	Active,
	Email,
	UserCategory)
VALUES(
	@UserName, 
	@PassWord, 
	@FullName, 
	@Admin, 
	@Active,
	@Email,
	@UserCategory)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Login]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUsers_Login]
	@UserName	nvarchar(20),
	@PassWord	nvarchar(50)
AS
SELECT	*
FROM	htUsers
WHERE (UPPER(UserName) = UPPER(@UserName)) AND (PassWord=@PassWord) and Active=1
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsers_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUsers_Update]
	@UserID  int,
	@FullName  nvarchar(50),
	@Admin  bit,
	@Active  bit,
	@Email nvarchar(100),
	@UserCategory INT
AS
UPDATE htUsers SET
	FullName = @FullName,
	Admin = @Admin,
	Active = @Active,
	Email = @Email,
	UserCategory = @UserCategory
WHERE (UserID = @UserID)

IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
Else
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_htUsersunction_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_htUsersunction_Load_List]
	@UserName nvarchar(50)
AS
SELECT * FROM htUserFunction a LEFT JOIN
htUsers b on a.UserID=b.UserID
WHERE (b.UserName = @UserName)
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Local_Delete]
	@LocalId INT
AS
	DELETE FROM	Local WHERE LocalId = @LocalId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Local_Insert] 
	@LocalCode NVARCHAR(MAX),
	@LocalName NVARCHAR(MAX)
AS
	INSERT INTO Local(LocalCode,LocalName)
	VALUES(@LocalCode,@LocalName)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Local_Load_List]
AS
	SELECT * FROM Local
GO
/****** Object:  StoredProcedure [dbo].[sp_Local_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Local_Update]
	@LocalCode NVARCHAR(MAX),
	@LocalName NVARCHAR(MAX),
	@LocalId INT
AS
	UPDATE Local SET 
	LocalCode = @LocalCode,
	LocalName = @LocalName
	WHERE LocalId = @LocalId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Manager_Delete]
	@ManagerId INT
AS
	DELETE FROM	Manager WHERE ManagerId = @ManagerId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Manager_Insert] 
	@ManagerName NVARCHAR(MAX),
	@Address NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Phone NVARCHAR(20),
	@Gender BIT,
	@Birth DATE,
	@UserId INT
AS
	INSERT INTO Manager(ManagerName,Address,Email,Phone,Gender,Birth,UserId)
	VALUES(@ManagerName,@Address,@Email,@Phone,@Gender,@Birth,@UserId)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Manager_Load_List]
AS
	SELECT * FROM Manager


GO
/****** Object:  StoredProcedure [dbo].[sp_Manager_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Manager_Update]
	@ManagerName NVARCHAR(MAX),
	@Address NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Phone NVARCHAR(20),
	@Gender BIT,
	@Birth DATE,
	@UserId INT,
	@ManagerId INT
AS
	UPDATE Manager SET 
	ManagerName = @ManagerName,
	Address = @Address,
	Email = @Email,
	Phone = @Phone,
	Gender = @Gender,
	Birth = @Birth,
	UserId = @UserId
	WHERE ManagerId = @ManagerId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerCommunity_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerCommunity_Delete]
	@ManagerId INT
AS 
DELETE FROM ManagerCommunity WHERE ManagerId = @ManagerId
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerCommunity_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerCommunity_Insert]
	@ManagerId INT,
	@CommunityId INT
AS
	INSERT INTO ManagerCommunity(ManagerId,CommunityId)
		VALUES(@ManagerId,@CommunityId)
	SELECT @@ROWCOUNT AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerCommunity_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerCommunity_Load_List]
AS
SELECT Manager.*,CommunityDonate.*,SupportType.SupportTypeName,Local.LocalName
FROM Manager
INNER JOIN ManagerCommunity
ON ManagerCommunity.ManagerId = Manager.ManagerId
INNER JOIN CommunityDonate 
ON ManagerCommunity.CommunityId = CommunityDonate.CommunityId
INNER JOIN SupportType
ON SupportType.SupportTypeId = CommunityDonate.SupportTypeId
INNER JOIN Local
ON Local.LocalId = CommunityDonate.LocalId
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerEvent_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerEvent_Delete]
	@ManagerId INT
AS 
DELETE FROM ManagerEvent WHERE ManagerId = @ManagerId
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerEvent_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerEvent_Insert]
	@ManagerId INT,
	@EventId INT
AS
	INSERT INTO ManagerEvent(ManagerId,EventId)
		VALUES(@ManagerId,@EventId)
	SELECT @@ROWCOUNT AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerEvent_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerEvent_Load_List]
AS
	SELECT Manager.*,Event.*,SupportType.SupportTypeName,Local.LocalName
	FROM Manager
	INNER JOIN ManagerEvent
	ON ManagerEvent.ManagerId = Manager.ManagerId
	INNER JOIN Event 
	ON ManagerEvent.EventId = Event.EventId
	INNER JOIN SupportType
	ON SupportType.SupportTypeId = Event.SupportTypeId
	INNER JOIN Local
	ON Local.LocalId = Event.LocalId



GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerPost_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerPost_Delete]
	@ManagerId INT
AS 
DELETE FROM ManagerPost WHERE ManagerId = @ManagerId
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerPost_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerPost_Insert]
	@ManagerId INT,
	@PostId INT
AS
	INSERT INTO ManagerPost(ManagerId,PostId)
		VALUES(@ManagerId,@PostId)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_ManagerPost_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ManagerPost_Load_List]
AS
	SELECT Manager.*,Post.*,SupportType.SupportTypeName,PostType.PostTypeName
	FROM Manager
	INNER JOIN ManagerPost
	ON ManagerPost.ManagerId = Manager.ManagerId
	INNER JOIN Post 
	ON ManagerPost.PostId = Post.PostId
	INNER JOIN SupportType
	ON SupportType.SupportTypeId = Post.SupportTypeId
	INNER JOIN PostType
	ON Post.PostTypeId = PostType.PostTypeId




GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_MoneyType_Delete]
	@MoneyTypeId INT
AS
	DELETE FROM MoneyType WHERE MoneyTypeId = @MoneyTypeId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_MoneyType_Insert]
	@MoneyTypeName NVARCHAR(50),
	@Ratio FLOAT
AS
	INSERT INTO MoneyType(MoneyTypeName,Ratio)
		VALUES(@MoneyTypeName,@Ratio)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_MoneyType_Load_List]
AS
SELECT * FROM MoneyType

GO
/****** Object:  StoredProcedure [dbo].[sp_MoneyType_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_MoneyType_Update]
	@MoneyTypeName NVARCHAR(50),
	@Ratio FLOAT,
	@MoneyTypeId INT
AS
	UPDATE MoneyType SET MoneyTypeName = @MoneyTypeName, Ratio = @Ratio WHERE MoneyTypeId = @MoneyTypeId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Participant_Delete]
	@ParticipantId INT
AS
	DELETE FROM	Participant WHERE ParticipantId = @ParticipantId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Participant_Insert] 
	@ParticipantName NVARCHAR(MAX),
	@Address NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Phone NVARCHAR(20),
	@Gender BIT,
	@DonateAmount DECIMAL,
	@Birth DATE,
	@UserId INT
AS
	INSERT INTO Participant(ParticipantName,Address,Email,Phone,Gender,DonateAmount,Birth,UserId)
	VALUES(@ParticipantName,@Address,@Email,@Phone,@Gender,@DonateAmount,@Birth,@UserId)
SELECT @@IDENTITY AS 'Identity'

SELECT * FROM Participant
GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Participant_Load_List]
AS
	SELECT * FROM Participant


GO
/****** Object:  StoredProcedure [dbo].[sp_Participant_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Participant_Update]
	@ParticipantName NVARCHAR(MAX),
	@Address NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Phone NVARCHAR(20),
	@Gender BIT,
	@DonateAmount DECIMAL,
	@Birth DATE,
	@UserId INT,
	@ParticipantId INT
AS
	UPDATE Participant SET 
	ParticipantName = @ParticipantName,
	Address = @Address,
	Email = @Email,
	Phone = @Phone,
	Gender = @Gender,
	DonateAmount = @DonateAmount,
	Birth = @Birth,
	UserId = @UserId
	WHERE ParticipantId = @ParticipantId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantCommunity_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantCommunity_Delete]
	@ParticipantId INT
AS 
DELETE FROM ParticipantCommunity WHERE ParticipantId = @ParticipantId
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantCommunity_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantCommunity_Insert] 
	@ParticipantId INT,
	@CommunityId INT,
	@Money DECIMAL,
	@MoneyTypeId INT
AS
	INSERT INTO ParticipantCommunity(ParticipantId,CommunityId,Money,MoneyTypeId)
		VALUES(@ParticipantId,@CommunityId,@Money,@MoneyTypeId)
	SELECT @@ROWCOUNT AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantCommunity_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantCommunity_Load_List]
AS
	SELECT Participant.*,CommunityDonate.*,SupportType.SupportTypeName,Local.LocalName,ParticipantCommunity.Money,money.*
	FROM Participant
	INNER JOIN ParticipantCommunity
	ON ParticipantCommunity.ParticipantId = Participant.ParticipantId
	INNER JOIN CommunityDonate 
	ON ParticipantCommunity.CommunityId = CommunityDonate.CommunityId
	INNER JOIN SupportType
	ON SupportType.SupportTypeId = CommunityDonate.SupportTypeId
	INNER JOIN Local
	ON Local.LocalId = CommunityDonate.LocalId
	INNER JOIN MoneyType money
	ON ParticipantCommunity.MoneyTypeId = Money.MoneyTypeId
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantEvent_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantEvent_Delete]
	@ParticipantId INT
AS 
DELETE FROM ParticipantEvent WHERE ParticipantId = @ParticipantId
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantEvent_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantEvent_Insert]
	@ParticipantId INT,
	@EventId INT,
	@Money DECIMAL,
	@MoneyTypeId INT
AS
	INSERT INTO ParticipantEvent(ParticipantId,EventId,Money,MoneyTypeId)
		VALUES(@ParticipantId,@EventId,@Money,@MoneyTypeId)
	SELECT @@ROWCOUNT AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantEvent_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantEvent_Load_List]
AS
	SELECT p.ParticipantId,p.ParticipantName,p.Address,p.Email,p.Phone,p.Gender,p.DonateAmount AS DonateByParticipant,p.Birth,p.UserId,ParticipantEvent.Money,money.*
	,Event.*,SupportType.SupportTypeName,Local.LocalName
	FROM Participant p
	INNER JOIN ParticipantEvent
	ON ParticipantEvent.ParticipantId = p.ParticipantId
	INNER JOIN Event 
	ON ParticipantEvent.EventId = Event.EventId
	INNER JOIN SupportType
	ON SupportType.SupportTypeId = Event.SupportTypeId
	INNER JOIN Local
	ON Local.LocalId = Event.LocalId
	INNER JOIN MoneyType money
	ON ParticipantEvent.MoneyTypeId = money.MoneyTypeId



GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantPost_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantPost_Delete]
	@ParticipantId INT
AS 
DELETE FROM ParticipantPost WHERE ParticipantId = @ParticipantId
IF @@ROWCOUNT = 0 
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantPost_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantPost_Insert]
	@ParticipantId INT,
	@PostId INT,
	@Money DECIMAL,
	@MoneyTypeId INT
AS
	INSERT INTO ParticipantPost(ParticipantId,PostId,Money,MoneyTypeId)
		VALUES(@ParticipantId,@PostId,@Money,@MoneyTypeId)
	SELECT @@ROWCOUNT AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_ParticipantPost_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ParticipantPost_Load_List]
AS
	SELECT Participant.*,Post.*,SupportType.SupportTypeName,ParticipantPost.Money,PostType.PostTypeName,money.*
	FROM Participant
	INNER JOIN ParticipantPost
	ON ParticipantPost.ParticipantId = Participant.ParticipantId
	INNER JOIN Post 
	ON ParticipantPost.PostId = Post.PostId
	INNER JOIN SupportType
	ON SupportType.SupportTypeId = Post.SupportTypeId
	INNER JOIN PostType
	ON Post.PostTypeId = PostType.PostTypeId
	INNER JOIN MoneyType money
	ON ParticipantPost.MoneyTypeId = money.MoneyTypeId




GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Post_Delete]
	@PostId INT
AS
	DELETE FROM	Post WHERE PostId = @PostId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Post_Insert] 
	@PostName NVARCHAR(MAX),
	@Slot INT,
	@Content NVARCHAR(MAX),
	@Image NVARCHAR(20),
	@Status int,
	@TotalAmount DECIMAL,
	@SupportTypeId INT,
	@PostTypeId INT,
	@Title NVARCHAR(MAX)
AS
	INSERT INTO Post(PostName,Slot,Content,Image,Status,TotalAmount,SupportTypeId,PostTypeId,Title)
	VALUES(@PostName,@Slot,@Content,@Image,@Status,@TotalAmount,@SupportTypeId,@PostTypeId,@Title)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Post_Load_List]
AS
	SELECT Post.*,SupportType.SupportTypeName ,PostType.PostTypeName
	FROM Post
	INNER JOIN SupportType ON Post.SupportTypeId = SupportType.SupportTypeId
	INNER JOIN PostType ON Post.PostTypeId = PostType.PostTypeId
GO
/****** Object:  StoredProcedure [dbo].[sp_Post_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Post_Update]
	@PostName NVARCHAR(MAX),
	@Slot INT,
	@Content NVARCHAR(MAX),
	@Image NVARCHAR(20),
	@Status int,
	@TotalAmount DECIMAL,
	@SupportTypeId INT,
	@PostTypeId INT,
	@Title NVARCHAR(MAX),
	@PostId INT
AS
	UPDATE Post SET 
	PostName = @PostName,
	Slot = @Slot,
	Content = @Content,
	Image = @Image,
	Status = @Status,
	SupportTypeId = @SupportTypeId,
	PostTypeId = @PostTypeId,
	Title = @Title
	WHERE PostId = @PostId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PostType_Delete]
	@PostTypeId INT
AS
	DELETE FROM PostType WHERE PostTypeId = @PostTypeId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PostType_Insert]
@PostTypeName NVARCHAR(MAX)
AS
INSERT INTO PostType(PostTypeName)
	VALUES(@PostTypeName)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PostType_Load_List]
AS
SELECT * FROM PostType
GO
/****** Object:  StoredProcedure [dbo].[sp_PostType_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PostType_Update]
	@PostTypeName NVARCHAR(MAX),
	@PostTypeId INT
AS
	UPDATE PostType SET PostTypeName = @PostTypeName
	WHERE PostTypeId = @PostTypeId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Delete]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SupportType_Delete]
	@SupportTypeId INT
AS
	DELETE FROM	SupportType WHERE SupportTypeId = @SupportTypeId
IF @@ROWCOUNT = 0
	SELECT 0 AS Deleted
ELSE
	SELECT 1 AS Deleted
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SupportType_Insert] 
	@SupportTypeName NVARCHAR(MAX)
AS
	INSERT INTO SupportType(SupportTypeName)
	VALUES(@SupportTypeName)
SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SupportType_Load_List]
AS
	SELECT * FROM SupportType
GO
/****** Object:  StoredProcedure [dbo].[sp_SupportType_Update]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SupportType_Update]
	@SupportTypeName NVARCHAR(MAX),
	@SupportTypeId INT
AS
	UPDATE SupportType SET 
	SupportTypeName = @SupportTypeName
	WHERE SupportTypeId = @SupportTypeId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_Update_Slot]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Update_Slot]
	@Category INT, 
	@UpdateSlotId INT  
AS
IF @Category = 1
    UPDATE CommunityDonate SET Slot = Slot+1 WHERE CommunityId = @UpdateSlotId
ELSE  
    UPDATE Event SET Slot = Slot + 1 WHERE EventId = @UpdateSlotId
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMoney_Category]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateMoney_Category]
	@Category INT,
	@Item INT,
	@Money DECIMAL,
	@Slot INT
AS
IF @Category = 1
    UPDATE CommunityDonate 
	SET 
		Slot = Slot + 1,
		TotalAmount = TotalAmount + @Money
	WHERE CommunityId = @Item
ELSE IF @Category = 2
    UPDATE Event 
	SET 
		Slot = Slot + 1,
		DonateAmount = DonateAmount + @Money
	WHERE EventId = @Item
ELSE IF @Category = 3
	UPDATE Post
	SET 
		Slot = Slot + 1,
		TotalAmount = TotalAmount + @Money
	WHERE PostId = @Item
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMoney_Participant]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateMoney_Participant]
	@Money DECIMAL,
	@UserId INT
AS
    UPDATE Participant 
	SET 
		DonateAmount = DonateAmount + @Money
	WHERE ParticipantId = (SELECT ParticipantId FROM Participant WHERE UserId = @UserId)
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus_Donor]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateStatus_Donor]
@Status INT,
@DonorId INT
AS
UPDATE Donor SET Status = @Status WHERE DonorId = @DonorId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus_Event]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateStatus_Event]
@Status INT,
@EventId INT
AS
UPDATE Event SET Status = @Status WHERE EventId = @EventId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus_Post]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateStatus_Post]
@Status INT,
@PostId INT
AS
UPDATE Post SET Status = @Status WHERE PostId = @PostId
IF @@ROWCOUNT = 0
	SELECT 0 AS Updated
ELSE
	SELECT 1 AS Updated

	
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEvent_Insert]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UserEvent_Insert]
	@TypeEvent INT,
	@Perform INT,
	@Content NVARCHAR(MAX),
	@Moment DATETIME,
	@IPAddress NVARCHAR(MAX),
	@UserName NVARCHAR(50)
AS
	INSERT INTO UserEvent(TypeEvent,Perform,Content,Moment,IPAddress,UserName)
				VALUES(@TypeEvent,@Perform,@Content,@Moment,@IPAddress,@UserName)
	SELECT @@IDENTITY AS 'Identity'
GO
/****** Object:  StoredProcedure [dbo].[sp_UserEvent_Load_List]    Script Date: 11/18/2021 3:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UserEvent_Load_List]
AS
	SELECT * FROM UserEvent
GO
